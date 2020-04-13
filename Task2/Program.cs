using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ChangeFirstName(1999, "Helen");
            person.ChangeLastName(2001, "Kot");
            person.ChangeFirstName(2004, "Ruby");
            person.ChangeLastName(2005, "Krets");

            for (int i = 1996; i < 2006; i++)
            {
                person.GetFullName(i);
            }
        }
    }
}
