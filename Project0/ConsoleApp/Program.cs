using Newtonsoft.Json;
using Project0.ConsoleApp;
using Project0.Library; //reference from the library folder 
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Project0
{

    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Tenzin",
                Degree = "BA",
                Hobbies = new List<string>()
                {
                    "Reading",
                    "Playing Games"
                }
            };
            string strResultJson = JsonConvert.SerializeObject(student);
            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("stored");

            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"student.json");
            //   Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            //  Console.WriteLine(resultStudent.ToString());

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach(DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    } 
}
