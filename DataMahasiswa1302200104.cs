using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_5
{
    internal class DataMahasiswa1302200104
    {
        public void ReadJSON()
        {
            //read json file
            string jsonFile = File.ReadAllText(@"C:\Users\asus\source\repos\modul6_kelompok_5\jurnal6_1_1302200104.json");
            //convert json to array
            dynamic data = JsonConvert.DeserializeObject(jsonFile);
            //print data
            Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress + " " + data.address.city + " " + data.address.state);
        }
    }
}