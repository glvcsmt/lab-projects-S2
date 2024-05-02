using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public enum CountryType
    {
        Antegria, 
        Arstotzka, 
        Impor, 
        Kolechia, 
        Obristan
    }
    public sealed class Passport : IDocument
    {

        string name;
        int passportNumber;

        public string Name { get => this.name; }
        public int PassportNumber { get => this.passportNumber; }

        public DateTime BirthDate { get; }

        public DateTime ExpiryDate { get; }

        public CountryType Country { get; }

        public Passport(string name, int passportNumber, DateTime birthDate, DateTime expiryDate, CountryType country)
        {

            this.name = name;
            this.passportNumber = passportNumber;
            ExpiryDate = expiryDate;
            Country = country;
            BirthDate = birthDate;
            if(BirthDate > DateTime.Today) throw new InvalidBirthdateException("A szuletesi ido kesobbi, mint a mai datum!");
        }

        public bool isNotExpired(DateTime date)
        {
            if(this.ExpiryDate > date) return true;
            return false;
        }

        public override string? ToString()
        {
            return $"Name: {this.name}\nPassport Number: {this.passportNumber}\nDate of birth: {this.BirthDate}" +
                $"\nCountry: {this.Country}\nValid until: {this.ExpiryDate}";
        }
    }
}
