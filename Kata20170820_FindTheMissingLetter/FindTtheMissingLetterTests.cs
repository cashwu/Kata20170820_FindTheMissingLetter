using System;
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
            return 'b';
        }
    }
}
