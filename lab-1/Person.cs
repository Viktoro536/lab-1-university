using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    class Person
    {
        string name { get; set; }
        string surname { get; set; }
        string hobby { get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                string pattern = @"[A-zА-яЁё]+$";
                string[] ser = Regex.Split(value, "name: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.name = ser[0];
                }
                else
                {
                    Console.WriteLine("Имя должно содержать буквы!");
                }
            }
        } //Свойство
        public void SetName(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[A-zА-яЁё]+$";
                string[] ser = Regex.Split(value, "name: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(ser[1]))
                {
                    this.name = ser[1];
                }
                else
                {
                    Console.WriteLine("Имя должно содержать буквы!");
                }
            }
            else
            {
                string pattern = @"[A-zА-яЁё]+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Имя должно содержать буквы!");
                }
            }
        }
        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                string pattern = @"[A-zА-яЁё]+$";
                string[] ser = Regex.Split(value, "surname: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.surname = ser[0];
                }
                else
                {
                    Console.WriteLine("Фамилия должна содержать буквы!");
                }
            }
        } //Свойство
        public void SetSurname(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[A-zА-яЁё]+$";
                string[] ser = Regex.Split(value, "surname: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(ser[1]))
                {
                    this.surname = ser[1];
                }
                else
                {
                    Console.WriteLine("Фамилия должна содержать буквы!");
                }
            }
            else
            {
                string pattern = @"[A-zА-яЁё]+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.surname = value;
                }
                else
                {
                    Console.WriteLine("Фамилия должна содержать буквы!");
                }
            }
        }
        public string Hobby
        {
            get
            {
                return this.hobby;
            }
            set
            {
                string pattern = @"[A-zА-яЁё]+$";
                string[] ser = Regex.Split(value, "hobby: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.hobby = ser[0];
                }
                else
                {
                    Console.WriteLine("Используйте только буквы!");
                }
            }
        } //Свойство
        public void SetHobby(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[A-zА-яЁё]+$";
                string[] ser = Regex.Split(value, "hobby: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(ser[1]))
                {
                    this.hobby = ser[1];
                }
                else
                {
                    Console.WriteLine("Используйте только буквы!");
                }
            }
            else
            {
                string pattern = @"[A-zА-яЁё]+$";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.hobby = value;
                }
                else
                {
                    Console.WriteLine("Используйте только буквы!");
                }
            }
        }
        public Person(string Name_, string Surname_, string Hobby_, bool setFile)
        {
            this.SetName(Name_, setFile);
            this.SetSurname(Surname_, setFile);
            this.SetHobby(Hobby_, setFile);
        }
        public Person(string Name_, string Surname_, string Hobby_)
        {
            this.SetName(Name_, false);
            this.SetSurname(Surname_, false);
            this.SetHobby(Hobby_, false);
        }
        public Person()
        {
            this.name = null;
            this.surname = null;
            this.hobby = null;
        }
        public virtual string Play(string str)
        {
            return str;
        }
    }
}
