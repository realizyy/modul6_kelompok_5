using Newtonsoft.Json;

namespace modul6_kelompok_5
{

    public class DataMahasiswa1302200055
    {
        public void ReadJSON()
        {
            //read json file
            string jsonFile = File.ReadAllText(@"C:\Users\Zaky\source\repos\modul6_kelompok_5\jurnal6_1_1302200055.json");
            //convert json to array
            dynamic data = JsonConvert.DeserializeObject(jsonFile);
            //print data
            Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress + " " + data.address.city + " " + data.address.state);
        }
    }
}
