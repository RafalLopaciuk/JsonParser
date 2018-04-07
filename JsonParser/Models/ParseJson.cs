using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonParser.Models
{
    class ParseJson
    {
        public List<Person> ListOfPersons { get; set; }

        public ParseJson(string filename)
        {
            string jsonData = File.ReadAllText(filename);

            ListOfPersons = JsonConvert.DeserializeObject<List<Person>>(jsonData);
        }

        public int getFemaleCount()
        {
            int femaleCount = 0;

            foreach (Person element in ListOfPersons)
            {
                if (element.gender == "female") femaleCount++;
            }

            return femaleCount;
        }

        public int getMaleCount()
        {
            int MaleCount = 0;

            foreach (Person element in ListOfPersons)
            {
                if (element.gender == "male") MaleCount++;
            }

            return MaleCount;
        }

        public double getAverageAge()
        {
            double avg = 0;

            foreach (Person element in ListOfPersons)
            {
                avg += element.age;
            }

            avg /= ListOfPersons.Count;

            return avg;
        }
    }
}
