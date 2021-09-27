using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> getRowlingWizardsLINQ() 
        {
            var wizards = Wizard.Wizards.Value;
            
            var output = from w in wizards
                         where w.Creator.Equals("J.K. Rowling")
                         select w.Name;

            return output;
        }

        public static IEnumerable<string> getRowlingWizardsExtension() 
        {
            var wizards = Wizard.Wizards.Value;
            
            var output = wizards.Where(w => w.Creator.Equals("J.K. Rowling")).Select(w => w.Name);

            return output;
        }

        public static int? getFirstSithLordYearLINQ() 
        {
            var wizards = Wizard.Wizards.Value;

            var output = from w in wizards
                         where w.Name.Contains("Darth")
                         orderby w.Year ascending
                         select w.Year;
                        
            return output.First();
        }

        public static int? getFirstSithLordYearExtension() 
        {
            var wizards = Wizard.Wizards.Value;

            var output = wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).Select(w => w.Year).First();
            
            return output;
        }

        public static IEnumerable<(string, int?)> getHarryPotterWizardsLINQ() 
        {
            var wizards = Wizard.Wizards.Value;

            var output = from w in wizards
                         where w.Medium.Equals("Harry Potter")
                         select (w.Name, w.Year);

            return output;
        }

        public static IEnumerable<(string, int?)> getHarryPotterWizardsExtension() 
        {
            var wizards = Wizard.Wizards.Value;

            var output = wizards.Where(w => w.Medium.Equals("Harry Potter")).Select(w => (w.Name, w.Year));

            return output;
        }

        public static IEnumerable<string> getWizardsGroupebByCreatorReverseOrderLINQ() 
        {
            var wizards = Wizard.Wizards.Value;

            var output = from w in wizards
                         orderby w.Creator descending, w.Name descending
                         select w.Name;


            return output;
        }

        public static IEnumerable<string> getWizardsGroupebByCreatorReverseOrderExtension() 
        {
            var wizards = Wizard.Wizards.Value;

            var output = wizards.OrderByDescending(w => w.Creator).ThenByDescending(w => w.Name).Select(w => w.Name);

            return output;
        }
    }
}
