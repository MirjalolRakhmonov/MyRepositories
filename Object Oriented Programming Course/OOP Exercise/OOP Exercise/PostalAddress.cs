using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    class PostalAddress
    {
        public string StreetName { get; private set; }
        public string HouseNumber { get; private set; }
        public string PostCode { get; private set; }
        public string City { get; private set; }
        public string CountryName { get; private set; }
        public string ApartmentNumber { get; private set; }

        public PostalAddress(string newStreetName, string newHouseNumber, string newPostCode, string newCity, string newCountryName, string newApartmentNumber)
        {
            this.StreetName = newStreetName;
            this.HouseNumber = newHouseNumber;
            this.PostCode = newPostCode;
            this.City = newCity;
            this.CountryName = newCountryName;
            this.ApartmentNumber = newApartmentNumber;  //18-26 Constructor done
        }

        public string WriteAdress
        {
            get
            {
                return $"My adress is: {this.StreetName}, {this.HouseNumber}, {this.PostCode}, {this.City}, {this.CountryName}, {this.ApartmentNumber}";
            }
        }
    }
}
