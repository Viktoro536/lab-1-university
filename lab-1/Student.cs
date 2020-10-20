using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    class Student : Person
    {
        string course;
        Person person;
        Identification_code id_code;
        Student_card st_card;
        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                string pattern = @"[1-9+$]\b";
                string[] ser = Regex.Split(value, "course: ");
                Regex series = new Regex(pattern);
                MatchCollection matches = series.Matches(ser[0]);
                if (series.IsMatch(value))
                {
                    this.course = ser[0];
                }
                else
                {
                    Console.WriteLine("Курс должен содержать число от 1 до 9");
                }
            }
        }
        public string Get_id_code()
        {
            return this.id_code.Code;
        }
        public string Get_stud_card()
        {
            return this.st_card.Card;
        }
        public string GetName()
        {
            return this.person.Name;
        }
        public string GetSurname()
        {
            return this.person.Surname;
        }
        public string GetHobby()
        {
            return this.person.Hobby;
        }
        public void SetCourse(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[1-9+$]\b";
                string[] ser = Regex.Split(value, "course: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(ser[1]))
                {
                    this.course = ser[1];
                }
                else
                {
                    Console.WriteLine("Курс должен содержать число от 1 до 9");
                }
            }
            else
            {
                string pattern = @"[1-9+$]\b";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.course = value;
                }
                else
                {
                    Console.WriteLine("Курс должен содержать число от 1 до 9");
                }
            }
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
        public void SetPerson(string Name_, string Surname_, string Hobby_, bool setFile)
        {
            this.person = new Person(Name_, Surname_, Hobby_, setFile);
        }
        public void SetSt_card(string St_code_, bool setFile)
        {
            this.st_card = new Student_card(St_code_, setFile);
        }
        public void SetId_code(string Code_, bool setFile)
        {
            this.id_code = new Identification_code(Code_, setFile);
        }
        public Student(string Name_, string Surname_, string Course_, string Hobby_, string St_code_, string Code_)
        {
            this.person = new Person(Name_, Surname_, Hobby_);
            this.SetCourse(Course_, false);
            this.st_card = new Student_card(St_code_, false);
            this.id_code = new Identification_code(Code_, false);
        }
        public Student(string Name_, string Surname_, string Course_, string Hobby_, string St_code_, string Code_, bool setFile)
        {
            this.person = new Person(Name_, Surname_, Hobby_, setFile);
            this.SetCourse(Course_, setFile);
            this.st_card = new Student_card(St_code_, setFile);
            this.id_code = new Identification_code(Code_, setFile);
        }
        public Student()
        {
            this.course = null;
            this.person = new Person();
            this.id_code = new Identification_code();
            this.st_card = new Student_card();
        }

        public override string Play(string str)
        {
            return base.Play(str);
        }
    }
}
