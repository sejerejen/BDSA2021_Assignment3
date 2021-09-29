using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BDSA2020.Assignment02
{
    public class Queries
    {
        public static IEnumerable<string> WizardsOfRowlingLINQ() 
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery = 
                from wiz in listOfWizards
                where wiz.Creator == "J.K. Rowling"
                select wiz.Name;

            return wizQuery;
        }
        public static IEnumerable<string> WizardsOfRowlingExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .Where(wiz=>wiz.Creator=="J.K. Rowling")
                                              .Select(wiz=>wiz.Name);
            return listOfWizards;
        }
        public static IEnumerable<int?> FirstSithLordLINQ()
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery =
                (from wiz in listOfWizards
                where wiz.Name.Contains("Darth")
                orderby wiz.Year
                select wiz.Year).Take(1);

                return wizQuery;
        }
        public static int? FirstSithLordExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .Where(Wiz=>Wiz.Name.StartsWith("Darth"))
                                              .OrderBy(wiz=>wiz.Year)
                                              .Select(wiz=>wiz.Year)
                                              .FirstOrDefault();

            return listOfWizards;
        }

        public static IEnumerable<(string, int?)> HarryPotterCharactersLINQ()
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery = 
                from wiz in listOfWizards
                where wiz.Medium.Contains("Harry Potter")
                select (wiz.Name, wiz.Year);

            return wizQuery;
        }

        public static IEnumerable<(string, int?)> HarryPotterCharactersExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .Where(wiz=>wiz.Medium.Contains("Harry Potter"))
                                              .Select(wiz=>(wiz.Name,wiz.Year));
            return listOfWizards;
        }

        public static IEnumerable<string> ListOfWizardsAndCreatorsLINQ()
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery = 
                from wiz in listOfWizards
                orderby wiz.Name descending
                orderby wiz.Creator descending
                group wiz by new {wiz.Creator, wiz.Name} into wizzy
                select wizzy.Key.Name;

            return wizQuery;
        }
        public static IEnumerable<string> ListOfWizardsAndCreatorsExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .OrderByDescending(wiz=>wiz.Creator).ThenByDescending(wiz=>wiz.Name)
                                              .GroupBy(wiz=>(wiz.Name,wiz.Creator))
                                              .Select(wiz=>wiz.Key.Name);
            return listOfWizards;
        }
    }
}
