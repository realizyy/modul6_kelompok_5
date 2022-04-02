using Newtonsoft.Json;

namespace modul6_kelompok_5;

public class DataMahasiswa1302204035
{
    public void ReadJSON()
    {
        //read json file
        string jsonFile = File.ReadAllText(@"D:\Telyuuu\.Semester 4\Github\KPL\modul6_kelompok_5\jurnal6_1_nim.json");
        //convert json to array
        dynamic data = JsonConvert.DeserializeObject(jsonFile);
        //print data
        Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress +" "+ data.address.city +" "+ data.address.state);
    }
}