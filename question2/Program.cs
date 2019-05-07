using System;
using System.Net;
using System.Collections.Generic;
using question2.Models;
using Newtonsoft.Json;


namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient wc = new WebClient())
            {
                string url = "https://jsonplaceholder.typicode.com/users?_limit=5";
                string json = wc.DownloadString(url);


                bool keepgoing = false;

                do
                {
                    Console.WriteLine("Enter 1 if your a User or 2 if your a Supervisor");
                    string input = Console.ReadLine();

                    if(input == "1")
                    {
                        Person p1 = new Person();
                        List<Person> data = JsonConvert.DeserializeObject<List<Person>>(json);
                        Console.WriteLine(p1.Display_Data(data));
                        keepgoing = true;
                    } else if(input == "2")
                    {
                        Supervisor p1 = new Supervisor();
                        List<Supervisor> data = JsonConvert.DeserializeObject<List<Supervisor>>(json);
                        Console.WriteLine(p1.Display_Data(data));
                        keepgoing = true;
                    } else
                    {
                        Console.WriteLine("You didn't enter 1 or 2");
                        keepgoing = false;
                    }

                } while (keepgoing == false);

                Console.ReadLine();
            }
        }
    }
}
