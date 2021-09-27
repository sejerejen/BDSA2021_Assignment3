using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BDSA2020.Assignment02
{
    public class Queries
    {
        public static void WizardsOfRowlingLINQ() 
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery = 
                from wiz in listOfWizards
                where wiz.Creator == "J.K. Rowling"
                select wiz.Name;

            wizQuery.Print();
        }
        public static void WizardsOfRowlingExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .Where(wiz=>wiz.Creator=="J.K. Rowling")
                                              .Select(wiz=>wiz.Name);
            listOfWizards.Print();
        }
        public static void FirstSithLordLINQ()
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery =
                (from wiz in listOfWizards
                where wiz.Name.Contains("Darth")
                orderby wiz.Year
                select wiz.Year).Take(1);

                wizQuery.Print();
        }
        public static void FirstSithLordExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .Where(Wiz=>Wiz.Name.StartsWith("Darth"))
                                              .OrderBy(wiz=>wiz.Year)
                                              .Select(wiz=>wiz.Year)
                                              .FirstOrDefault();

            listOfWizards.PrintSingle();
        }

        public static void HarryPotterCharactersLINQ()
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery = 
                from wiz in listOfWizards
                where wiz.Medium.Contains("Harry Potter")
                select new {Name=wiz.Name, Year=wiz.Year};

            wizQuery.Print();
        }

        public static void HarryPotterCharactersExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .Where(wiz=>wiz.Medium.Contains("Harry Potter"))
                                              .Select(wiz=>(wiz.Name,wiz.Year));
            listOfWizards.Print();
        }

        public static void ListOfWizardsAndCreatorsLINQ()
        {
            var listOfWizards = Wizard.Wizards.Value;

            var wizQuery = 
                from wiz in listOfWizards
                orderby wiz.Name descending
                orderby wiz.Creator descending
                group wiz by new {wiz.Creator, wiz.Name} into wizzy
                select wizzy.Key.Name;

            wizQuery.Print();
        }
        public static void ListOfWizardsAndCreatorsExtension()
        {
            var listOfWizards = Wizard.Wizards.Value
                                              .OrderByDescending(wiz=>wiz.Creator).ThenByDescending(wiz=>wiz.Name)
                                              .GroupBy(wiz=>(wiz.Name,wiz.Creator))
                                              .Select(wiz=>wiz.Key.Name);
            listOfWizards.Print();
        }
    }
}
