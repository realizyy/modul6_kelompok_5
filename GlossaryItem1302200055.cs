using Newtonsoft.Json;

namespace modul6_kelompok_5;

public class GlossaryItem1302200055
{
    public void ReadJSON()
    {
        //path
        string loc = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //read Json file
        string json = File.ReadAllText(loc + "\\jurnal6_3_1302200055.json");
        //convert json
        dynamic data = JsonConvert.DeserializeObject(json);
        dynamic gentry = data.glossary.GlossDiv.GlossList.GlossEntry;
        //print data
        Console.WriteLine("ID : " + gentry.ID + "\nSortAs : " + gentry.SortAs + "\nGlossTerm : " + gentry.GlossTerm + "\nAcronym : " + gentry.Acronym + "\nAbbrev : " + gentry.Abbrev);


    }
}