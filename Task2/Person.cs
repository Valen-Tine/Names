using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person
    {
        string first_name = "with unknown last name";
        string last_name = "with unknown first name";
        int min_year = 5000;

        
        public Dictionary<int, string> Changes = new Dictionary<int, string> { };

        public void ChangeFirstName(int year, string first_name)
        {
            if (min_year > year)
                min_year = year;
            this.first_name = first_name; 
            Changes.Add(year, first_name + " " + last_name);
        }

        public void ChangeLastName(int year, string last_name)
        {
            if (min_year > year)
                min_year = year;

            this.last_name = last_name;
            Changes.Add(year, first_name + " " + last_name);
        }

        public void GetFullName(int year)
        {
            int c = 0;
            if (Changes.ContainsKey(year))
                Console.WriteLine($"В {year} году имя {Changes[year]}.");
            else if(!Changes.ContainsKey(year) && year > min_year)
            {
                Changes[year] = Changes[year - 1];
                Console.WriteLine($"В {year} году имя {Changes[year]}.");
            }

            else if(year < min_year)
                Console.WriteLine("Incognito");

        }
    }
}
