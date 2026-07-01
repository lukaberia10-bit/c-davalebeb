using System;
using System.Collections.Generic;
using System.Text;

namespace homework10
{
    public class Employ
    {
        public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public country Country { get; set; }
    public Gender Gender { get; set; }
    public Contacts Contact { get; set; }

    public Employ(string name, string surname, DateTime dateOfBirth,
        country country, Gender gender, Contacts contact)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
        Country = country;
        Gender = gender;
        Contact = contact;
    }

    public int GetAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;

        if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            age--;

        return age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} {Surname} - Age: {GetAge()} - Country: {Country}");
    }
    }
}
