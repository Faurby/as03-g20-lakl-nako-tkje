using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Wizards_Invented_By_Rowling_Return_8_LINQ()
        {
            var expected = 8;
            var actual = Queries.getRowlingWizardsLINQ().Count();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Wizards_Invented_By_Rowling_Return_8_Extension()
        {
            var expected = 8;
            var actual = Queries.getRowlingWizardsExtension().Count();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Year_The_First_Sith_Lord_Was_Introduced_LINQ()
        {

            var expected = 1977;
            var actual = Queries.getFirstSithLordYearLINQ();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Year_The_First_Sith_Lord_Was_Introduced_Extension()
        {

            var expected = 1977;
            var actual = Queries.getFirstSithLordYearExtension();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Unique_List_Of_Wizards_From_Harry_Potter_Books_Return_As_NameYear_Tuple_LINQ()
        {

            var expected = new List<(string, int?)> {("Harry Potter", 1997),
                                                    ("Hermione Granger", 1997),
                                                    ("Ron Weasley", 1997),
                                                    ("Albus Dumbledore", 1997),
                                                    ("Neville Longbottom", 1997),
                                                    ("Gilderoy Lockhart", 1997),
                                                    ("Minerva McGonagall", 1997),
                                                    ("Severus Snape", 1997)};

            var actual = Queries.getHarryPotterWizardsLINQ();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Unique_List_Of_Wizards_From_Harry_Potter_Books_Return_As_NameYear_Tuple_Extension()
        {
            var expected = new List<(string, int?)> {("Harry Potter", 1997),
                                                                ("Hermione Granger", 1997),
                                                                ("Ron Weasley", 1997),
                                                                ("Albus Dumbledore", 1997),
                                                                ("Neville Longbottom", 1997),
                                                                ("Gilderoy Lockhart", 1997),
                                                                ("Minerva McGonagall", 1997),
                                                                ("Severus Snape", 1997)};

            var actual = Queries.getHarryPotterWizardsExtension();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void List_Wizard_Names_Grouped_By_Creator_In_Revese_Order_By_CreatorName_And_WizardName_LINQ()
        {
            var expected = new List<string> {
                "Will Byers",
                "Wizard of Oz",
                "Sauron",
                "Gandalf",
                "Severus Snape",
                "Ron Weasley",
                "Neville Longbottom",
                "Minerva McGonagall",
                "Hermione Granger",
                "Harry Potter",
                "Gilderoy Lockhart",
                "Albus Dumbledore",
                "Darth Vader",
                "Darth Maul",
                "Mickey Mouse",
                "Max Russo",
                "Justin Russo",
                "Alex Russo"
            };

            var actual = Queries.getWizardsGroupebByCreatorReverseOrderLINQ();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void List_Wizard_Names_Grouped_By_Creator_In_Revese_Order_By_CreatorName_And_WizardName_Extension()
        {
            var expected = new List<string> {
                "Will Byers",
                "Wizard of Oz",
                "Sauron",
                "Gandalf",
                "Severus Snape",
                "Ron Weasley",
                "Neville Longbottom",
                "Minerva McGonagall",
                "Hermione Granger",
                "Harry Potter",
                "Gilderoy Lockhart",
                "Albus Dumbledore",
                "Darth Vader",
                "Darth Maul",
                "Mickey Mouse",
                "Max Russo",
                "Justin Russo",
                "Alex Russo"
            };

            var actual = Queries.getWizardsGroupebByCreatorReverseOrderExtension();

            Assert.Equal(expected, actual);
        }
    }
}
