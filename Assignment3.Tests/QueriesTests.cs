using System;
using System.Collections.Generic;
using BDSA2020.Assignment02;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void RowlingTest1()
        {
            //arrange
            var actual = Queries.WizardsOfRowlingLINQ();
            IEnumerable<string> expected = new List<string> {"Harry Potter","Albus Dumbledore"};

            //act


            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RowlingTest2()
        {
            //arrange
            var actual = Queries.WizardsOfRowlingExtension();
            IEnumerable<string> expected = new List<string> {"Harry Potter","Albus Dumbledore"};

            //act


            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FirstSithTest1()
        {
            var actual = Queries.FirstSithLordLINQ();
            IEnumerable<int?> expected = new List<int?> {1977};

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FirstSithTest2()
        {
            var actual = Queries.FirstSithLordExtension();
            var expected = 1977;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void HPCharacterTest1()
        {
            var actual = Queries.HarryPotterCharactersLINQ();
            var expected = new List<(string, int?)> {("Harry Potter", 1997), ("Albus Dumbledore", 1997)};

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void HPCharacterTest2()
        {
            var actual = Queries.HarryPotterCharactersExtension();
            var expected = new List<(string, int?)> {("Harry Potter", 1997), ("Albus Dumbledore", 1997)};

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void listofWAndCTest1()
        {
            var actual = Queries.ListOfWizardsAndCreatorsLINQ();
            var expected = new List<string> {"Dr. Strange", "Tim", "The wizard of Oz", "Sauron", "Gandalf", "Harry Potter", "Albus Dumbledore", "Yoda", "Luke skywalker", "Darth Vader", "Darth Maul"};

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void listofWAndCTest2()
        {
            var actual = Queries.ListOfWizardsAndCreatorsExtension();
            var expected = new List<string> {"Dr. Strange", "Tim", "The wizard of Oz", "Sauron", "Gandalf", "Harry Potter", "Albus Dumbledore", "Yoda", "Luke skywalker", "Darth Vader", "Darth Maul"};

            Assert.Equal(expected, actual);
        }
    }
}
