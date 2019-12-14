using System;

namespace ShopConsole.Models
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Street { get; private set; }
        public int HouseNumber { get; private set; }
        public string PostCode { get; private set; }
        public string City { get; private set; }
        public int Nip { get; private set; }

        public void ChangeName(string firstname, string lastname)
        {
            if(string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
            {
                Console.WriteLine("Your name cannot be empty!");
                return;
            }
            if(firstname == FirstName && lastname == LastName)
            {
                Console.WriteLine("Your new name is equal to the old one.");
                return;
            }
            FirstName = firstname;
            LastName = lastname;
        }
        public void ChangeAddress(string street, int housenumber, string postcode, string city)
        {
            if(string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(postcode) || string.IsNullOrWhiteSpace(city))
            {
                //throw new Exception("Field cannot be empty!");
                Console.WriteLine("Field cannot be empty!");
                return;
            }
            if(street == Street && housenumber == HouseNumber && postcode == PostCode && city == City)
            {
                Console.WriteLine("Your new address is equal to the old one.");
                return;
            }
            Street = street;
            HouseNumber = housenumber;
            PostCode = postcode;
            City = city;
        }
        public void ChangeAddress(string street, int housenumber, string postcode, string city, int nip)
        {
            if(string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(postcode) || string.IsNullOrWhiteSpace(city))
            {
                //throw new Exception("Field cannot be empty!");
                Console.WriteLine("Field cannot be empty!");
                return;
            }
            if(street == Street && housenumber == HouseNumber && postcode == PostCode && city == City)
            {
                Console.WriteLine("Your new address is equal to the old one.");
                return;
            }
            Street = street;
            HouseNumber = housenumber;
            PostCode = postcode;
            City = city;
            Nip = nip;
        }
    }
}