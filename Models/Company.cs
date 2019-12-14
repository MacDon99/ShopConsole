using System;

namespace ShopConsole
{
    public class Company
    {
        public string Name { get; private set; }
        public int Nip { get; private set; }
        
        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                //throw new Exception("Your company name cannot be empty!");
                Console.WriteLine("Your company name cannot be empty!");
                return;
            }
            if(name == Name)
            {
                Console.WriteLine("Your new company name is equal to the old one.");
                return;
            }
            Name = name;
        }
        public void SetNip(int nip)
        {
            if(nip == Nip)
            {
                Console.WriteLine("Your new nip is equal ot the old one.");
                return;
            }
            Nip = nip;
        }
    }
}