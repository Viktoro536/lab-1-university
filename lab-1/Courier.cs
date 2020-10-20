using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    class Courier : Person
    {
        string product;
        Person person;
        Identification_code id_code;
        string delivery_address;
        public string Product
        {
            get
            {
                return this.product;
            }
            set
            {
                string pattern = @"\d+$";
                string[] ser = Regex.Split(value, "product: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.product = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите код товара, без пробелов! (например: 111111");
                }
            }
        }
        public string Delivery_address
        {
            get
            {
                return this.delivery_address;
            }
            set
            {
                string pattern = @"[A-zА-я0-9]+$";
                string[] ser = Regex.Split(value, "delivery_address: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.delivery_address = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите адресс заказчика без знаков препинания и пробелов!");
                }
            }
        }
        public string Get_id_code()
        {
            return id_code.Code;
        }
        public string Get_delivery_address()
        {
            return delivery_address;
        }
        public string GetName()
        {
            return person.Name;
        }
        public string GetSurname()
        {
            return person.Surname;
        }
        public string GetHobby()
        {
            return person.Hobby;
        }
        public string GetProduct()
        {
            return this.product;
        }
        public void SSetName(string value, bool setFile)
        {
            this.person.SetName(value, setFile);
        }
        public void SSetSurname(string value, bool setFile)
        {
            this.person.SetSurname(value, setFile);
        }
        public void SSetHobby(string value, bool setFile)
        {
            this.person.SetHobby(value, setFile);
        }
        public void SetProduct(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"\d+$";
                string[] ser = Regex.Split(value, "product: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.product = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите код товара, без пробелов! (например: 111111");
                }
            }
            else
            {
                string pattern = @"\d+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.product = value;
                }
                else
                {
                    Console.WriteLine("Введите код товара, без пробелов! (например: 111111");
                }
            }
        }
        public void SetDelivery_address(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[A-zА-я0-9]+$";
                string[] ser = Regex.Split(value, "delivery address: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.delivery_address = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите адресс заказчика без знаков препинания и пробелов!");
                }
            }
            else
            {
                string pattern = @"[A-zА-я0-9]+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.delivery_address = value;
                }
                else
                {
                    Console.WriteLine("Введите адресс заказчика без знаков препинания и пробелов!");
                }
            }
        }
        public void SetId_code(string Code_, bool setFile)
        {
            this.id_code = new Identification_code(Code_, setFile);
        }
        public void SetPerson(string Name_, string Surname_, string Hobby_, bool setFile)
        {
            this.person = new Person(Name_, Surname_, Hobby_, setFile);
        }
        public Courier(string Name_, string Surname_, string Product_, string Hobby_, string Delivery_address_, string Code_)
        {
            this.person = new Person(Name_, Surname_, Hobby_);
            this.SetProduct(Product_, false);
            this.SetDelivery_address(Delivery_address_, false);
            this.id_code = new Identification_code(Code_, false);
        }
        public Courier(string Name_, string Surname_, string Product_, string Hobby_, string Delivery_address_, string Code_, bool setFile)
        {
            this.person = new Person(Name_, Surname_, Hobby_, setFile);
            this.SetProduct(Product_, setFile);
            this.SetDelivery_address(Delivery_address_, setFile);
            this.id_code = new Identification_code(Code_, setFile);
        }
        public Courier()
        {
            this.product = null;
            this.person = new Person();
            this.id_code = new Identification_code();
            this.delivery_address = null;
        }
        public override string Play(string str)
        {
            return base.Play(str);
        }

    }
}
