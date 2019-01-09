using FluentAssertions;
using Xunit;

namespace LongestCommonSubsequence
{
    public class SubsequencerTests
    {
        Subsequencer subsequencer = new Subsequencer();

        [Fact]
        public void EmptyStrings_ShouldHaveEmptyResult()
        {
            SubsequenceOf(string.Empty, string.Empty).Should().BeEmpty();
        }

        [Fact]
        public void OneSameCharStrings_ShouldHaveCharAsResult()
        {
            SubsequenceOf("a", "a").Should().Be("a");
        }

        [Fact]
        public void OneDifferentCharStrings_ShouldHaveEmptyResult()
        {
            SubsequenceOf("a", "b").Should().BeEmpty();
        }

        [Fact]
        public void OneCommonCharacter_ShouldReturnCharacter()
        {
            SubsequenceOf("aa", "a").Should().Be("a");
        }

        [Fact]
        public void OneCommonCharacterOnSecondIndex_ShouldReturnCharacter()
        {
            SubsequenceOf("ba", "a").Should().Be("a");
        }

        [Fact]
        public void TwoCommonCharacter_ShouldReturnBoth()
        {
            SubsequenceOf("aba", "bba").Should().Be("ba");
        }

        [Fact]
        public void SeparatedSubsequences_ShouldBeFound()
        {
            SubsequenceOf("acba", "adbfa").Should().Be("aba");
        }

        [Fact]
        public void NullStrings_ShouldHaveEmptyResult()
        {
            SubsequenceOf(null, null).Should().BeEmpty();
        }

        // Todo: Clarify
        // "CDAB", "ABCD" => "CD" or "AB"?
        // Assumtion: First of first string => "CD"
        [Fact]
        public void TwoSubsequencesWithSameLength_FirstOfFirstStringShouldBeReturned()
        {
            SubsequenceOf("cdab", "abcd").Should().Be("cd");
        }

        [Fact]
        public void AllGivenExamples_ShouldWorkAsGiven()
        {
            SubsequenceOf("ABAZDC", "BACBAD").Should().Be("ABAD");
            SubsequenceOf("AGGTAB", "GXTXAYB").Should().Be("GTAB");
            SubsequenceOf("aaa", "aa").Should().Be("aa");
            SubsequenceOf("", "...").Should().Be("");
            SubsequenceOf("ABBA", "ABCABA").Should().Be("ABBA");
        }

        private string SubsequenceOf(string s1, string s2)
        {
            return subsequencer.FindLongestCommonSubsequence(s1, s2);
        }
    }
}
