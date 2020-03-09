using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Anagrams;

namespace AnagramsTest
{
    public class AnagramsGeneratorTest
    {
        [Fact]
        public void TestAnagramsGeneratorWillReturnHWhenPassedH()
        {
            List<string> expectedAnagrams = new List<string>(){
                "H"
            };

            var anagrams = AnagramsGenerator.generateAnagrams("H");
            anagrams.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Fact]
        public void TestAnagramsGeneratorWillReturnAllAnagramsWhenPassedHI()
        {
            List<string> expectedAnagrams = new List<string>(){
                "HI",
                "IH"
            };

            var anagrams = AnagramsGenerator.generateAnagrams("HI");
            anagrams.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Fact]
        public void TestAnagramsGeneratorWillReturnAllAnagramsWhenPassedHIM()
        {
            List<string> expectedAnagrams = new List<string>(){
                "HIM",
                "HMI",
                "MHI",
                "MIH",
                "IHM",
                "IMH"
            };

            var anagrams = AnagramsGenerator.generateAnagrams("HIM");
            anagrams.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Fact]
        public void TestAnagramsGeneratorWillReturnAllAnagramsWhenPassedBIRO()
        {
            List<string> expectedAnagrams = new List<string>(){
                "BIRO",
                "BIOR",
                "BRIO",
                "BROI",
                "BOIR",
                "BORI",
                
                "IBRO",
                "IBOR",
                "IRBO",
                "IROB",
                "IOBR",
                "IORB",

                "RBIO",
                "RBOI",
                "RIBO",
                "RIOB",
                "ROIB",
                "ROBI",

                "OBIR",
                "OBRI",
                "OIBR",
                "OIRB",
                "ORBI",
                "ORIB"
            };

            var anagrams = AnagramsGenerator.generateAnagrams("BIRO");
            anagrams.Should().BeEquivalentTo(expectedAnagrams);
        }
    }
}
