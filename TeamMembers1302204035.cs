using Newtonsoft.Json;

namespace modul6_kelompok_5;

public class TeamMembers1302204035
{
    
    public void ReadJSON()
    {
        //path
        string loc = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //read json file
        string jsonFile = File.ReadAllText(loc + "\\jurnal6_2_1302204035.json");
        //convert json
        dynamic data = JsonConvert.DeserializeObject(jsonFile);
        //print data
        Console.WriteLine("Team member list :");
        foreach (var item in data.members)
        {
            Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName + " (" + item.age + " " + item.gender + ")" );
        }
    }
}