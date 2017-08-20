using System;
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

        [TestMethod]
        public void input_a_should_return_b()
        {
            FindMissingLetterShouldBe('e', new[] { 'a', 'b', 'c', 'd', 'f' });
        }

        [TestMethod]
        public void input_A_should_return_b()
        {
            FindMissingLetterShouldBe('P', new[] { 'O', 'Q', 'R', 'S' });
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i + 1] - array[i] > 1)
                {
                    return Convert.ToChar(array[i] + 1);
                }
            }

            return ' ';
        }
    }
}
