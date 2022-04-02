using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_5
{
    public class GlossaryItem1302204011
    {
        public void ReadJSON()
        {
            string loc = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string json = File.ReadAllText(loc + "\\jurnal6_3_1302204011.json");

            dynamic data = JsonConvert.DeserializeObject(json);
            dynamic gentry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("ID : " + gentry.ID + "\nSortAs : " + gentry.SortAs + "\nGlossTerm : " + gentry.GlossTerm + "\nAcronym : " + gentry.Acronym + "\nAbbrev : " + gentry.Abbrev);
        }
    }
}
