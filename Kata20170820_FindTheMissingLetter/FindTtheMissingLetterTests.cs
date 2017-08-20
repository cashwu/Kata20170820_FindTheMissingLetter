﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170820_FindTheMissingLetter
{
    [TestClass]
    public class FindTtheMissingLetterTests
    {
        [TestMethod]
        public void input_a_c_should_return_b()
        {
            FindMissingLetterShouldBe('b', new[] {'a', 'c'});
        }

        [TestMethod]
        public void input_b_d_should_return_b()
        {
            FindMissingLetterShouldBe('c', new[] { 'b', 'd' });
        }

        private static void FindMissingLetterShouldBe(char expected, char[] array)
        {
            var kata = new Kata();
            var actual = kata.FindMissingLetter(array);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public char FindMissingLetter(char[] array)
        {
            var firstAsc2 = Convert.ToInt32(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (firstAsc2 - Convert.ToInt32(array[i]) < 0)
                {
                    return Convert.ToChar(firstAsc2 + 1);
                }

                firstAsc2++;
            }

            return 'a';
        }
    }
}
