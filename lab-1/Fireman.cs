using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    class Fireman : Person
    {
        string fireman_certificate_number;
        Person person;
        Identification_code id_code;
        string call_address;
        public string Fireman_certificate_number
        {
            get
            {
                return this.fireman_certificate_number;
            }
            set
            {
                string pattern = @"\d+$";
                string[] ser = Regex.Split(value, "fireman certificate number: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.fireman_certificate_number = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите номер удостоверения пожарника, без пробелов! (например: 111111");
                }
            }
        }
        public string Сall_address
        {
            get
            {
                return this.call_address;
            }
            set
            {
                string pattern = @"[A-zА-я0-9]+$";
                string[] ser = Regex.Split(value, "call address: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.call_address = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите адресс вызова без знаков препинания и пробелов!");
                }
            }
        }
        public string Get_id_code()
        {
            return id_code.Code;
        }
        public string Get_call_address()
        {
            return call_address;
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
        public string GetFireman_certificate_number()
        {
            return this.fireman_certificate_number;
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
        public void SetFireman_certificate_number(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"\d+$";
                string[] ser = Regex.Split(value, "fireman certificate number: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.fireman_certificate_number = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите номер удостоверения пожарника, без пробелов! (например: 111111");
                }
            }
            else
            {
                string pattern = @"\d+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.fireman_certificate_number = value;
                }
                else
                {
                    Console.WriteLine("Введите номер удостоверения пожарника, без пробелов! (например: 111111");
                }
            }
        }
        public void SetСall_address(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[A-zА-я0-9]+$";
                string[] ser = Regex.Split(value, "call address: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.call_address = ser[1];
                }
                else
                {
                    Console.WriteLine("Введите адресс вызова без знаков препинания и пробелов!");
                }
            }
            else
            {
                string pattern = @"[A-zА-я0-9]+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.call_address = value;
                }
                else
                {
                    Console.WriteLine("Введите адресс вызова без знаков препинания и пробелов!");
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
        public Fireman(string Name_, string Surname_, string Fireman_certificate_number_, string Hobby_, string Сall_address_, string Code_)
        {
            this.person = new Person(Name_, Surname_, Hobby_);
            this.SetFireman_certificate_number(Fireman_certificate_number_, false);
            this.SetСall_address(Сall_address_, false);
            this.id_code = new Identification_code(Code_, false);
        }
        public Fireman(string Name_, string Surname_, string Fireman_certificate_number_, string Hobby_, string Сall_address_, string Code_, bool setFile)
        {
            this.person = new Person(Name_, Surname_, Hobby_, setFile);
            this.SetFireman_certificate_number(Fireman_certificate_number_, setFile);
            this.SetСall_address(Сall_address_, setFile);
            this.id_code = new Identification_code(Code_, setFile);
        }
        public Fireman()
        {
            this.call_address = null;
            this.person = new Person();
            this.id_code = new Identification_code();
            this.fireman_certificate_number = null;
        }
        public override string Play(string str)
        {
            return base.Play(str);
        }
    }
}
