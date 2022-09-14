using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Adress{

        private string country;
        private string city;
        private string street;
        private int house;

        public Adress(){
      this.Country = "Ukraine";
      this.City = "Kherson";
      this.Street = "Ilicha";
      this.House = 92;
        }

    public Adress(string country, string city, string street, int house)
    {
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
    }

    public override string ToString()
    {
        return
            "Country: " + this.country + "\n" +
            "City: " + this.city + "\n" +
            "Street: " + this.street + "\n" +
            "House: " + this.house.ToString() + "\n";
    }

    public string Country { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public int House { get; set; }
}
}
