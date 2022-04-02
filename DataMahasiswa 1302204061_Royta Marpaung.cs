using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_5
{
    public class DataMahasiswa1302204061
    {
        public void ReadJSON()
        {
            //path
            string loc = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //read json file
            string jsonFile = File.ReadAllText(@"C:\Users\Lenovo\OneDrive\Documents\My File\Kumpulan Materi\Konstruksi Perangkat Lunak\Praktikum\KPL_MOD6_1302204061_DHF\modul6_kelompok_5\jurnal6_1_1302204061.json");
            //convert json to array
            dynamic data = JsonConvert.DeserializeObject(jsonFile);
            //print data
            //print data
            Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress +" "+ data.address.city +" "+ data.address.state);
        }
    }
}