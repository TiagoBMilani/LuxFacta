using DesafioLuxfacta.ConsoleApplication.Challenges;
using System;
using Xunit;

namespace DesafioLuxfacta.UnitTests
{
    public class PalindromeChallengeTest
    {
        [Fact]
        public void ExampleCase_ReturnTrue()
        {
            Assert.True(Palindrome.IsPalindrome("omississimo"));
        }

        [Fact]
        public void SimplePalindromesCase_ReturnTrue()
        {
            Assert.True(Palindrome.IsPalindrome("Ama"));

            Assert.True(Palindrome.IsPalindrome("amA"));
        }

        [Fact]
        public void OddAndEvenCase_ReturnTrue()
        {
            Assert.True(Palindrome.IsPalindrome("amma"));

            Assert.True(Palindrome.IsPalindrome("ana"));

            Assert.True(Palindrome.IsPalindrome("romametemamor"));
        }

        [Fact]
        public void NonPalindromes_ReturnFalse()
        {
            Assert.False(Palindrome.IsPalindrome("ammnma"));

            Assert.False(Palindrome.IsPalindrome("not a palindrome"));
        }

        [Fact]
        public void EmptyWord_ReturnTrue()
        {
            Assert.True(Palindrome.IsPalindrome(""));
        }

        [Fact]
        public void LongPalindromes_ReturnTrue()
        {
            Assert.True(Palindrome.IsPalindrome("aaaaaaaaaababaaaaaaaaaa"));

            Assert.True(Palindrome.IsPalindrome("aaaaaaaaaabbaaaaaaaaaa"));
        }
    }
}
