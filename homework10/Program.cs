using System.Diagnostics.Metrics;

namespace homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] employs = new Employ[8];

            employs[0] = new Employ("Giorgi", "Beridze", new DateTime(2000, 5, 10), country.Georgia, Gender.Male, Contacts.Phone);
            employs[1] = new Employ("Nino", "Gelashvili", new DateTime(2001, 6, 15), country.Georgia, Gender.Female, Contacts.Email);

            employs[2] = new Employ("John", "Smith", new DateTime(1999, 3, 20), country.USA, Gender.Male, Contacts.Phone);
            employs[3] = new Employ("Emma", "Brown", new DateTime(2002, 4, 11), country.USA, Gender.Female, Contacts.Fax);

            employs[4] = new Employ("Hans", "Muller", new DateTime(1998, 7, 12), country.Germany, Gender.Male, Contacts.Email);
            employs[5] = new Employ("Anna", "Schmidt", new DateTime(2001, 8, 22), country.Germany, Gender.Female, Contacts.Phone);

            employs[6] = new Employ("Pierre", "Martin", new DateTime(1997, 9, 5), country.France, Gender.Male, Contacts.Fax);
            employs[7] = new Employ("Sophie", "Dubois", new DateTime(2003, 10, 30), country.France, Gender.Female, Contacts.Email);

            Helper.PrintByCountry(employs, country.Georgia);
        }
    }
}
