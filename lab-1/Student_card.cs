using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    class Student_card
    {
        string card;
        public string Card
        {
            get
            {
                return this.card;
            }
            set
            {
                string pattern = @"[(^0-9)A-ZА-Я{2}]+[(^A-zА-я)0-9{8}\b]";
                string[] ser = Regex.Split(value, "student card: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.card = ser[1];
                }
                else
                {
                    Console.WriteLine("Серия должна состоять из 2 букв верхнего регистра и 8 цифр!");
                }
            }
        } //Свойство
        public void SetCard(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[(^0-9)A-ZА-Я{2}]+[(^A-zА-я)0-9{8}\b]";
                string[] ser = Regex.Split(value, "student card: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(ser[1]))
                {
                    this.card = ser[1];
                }
                else
                {
                    Console.WriteLine("Серия должна состаять из 2 букв верхнего регистра и 8 цифр!");
                }
            }
            else
            {
                string pattern = @"[(^0-9)A-ZА-Я{2}]+[(^A-zА-я)0-9{8}\b]";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.card = value;
                }
                else
                {
                    Console.WriteLine("Серия должна состаять из 2 букв верхнего регистра и 8 цифр!");
                }
            }
        }
        public Student_card(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[(^0-9)A-ZА-Я{2}]+[(^A-zА-я)0-9{8}\b]";
                string[] ser = Regex.Split(value, "student card: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(ser[1]))
                {
                    this.card = ser[1];
                }
                else
                {
                    Console.WriteLine("Серия должна состаять из 2 букв верхнего регистра и 8 цифр!");
                }
            }
            else
            {
                string pattern = @"[(^0-9)A-ZА-Я{2}]+[(^A-zА-я)0-9{8}\b]";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.card = value;
                }
                else
                {
                    Console.WriteLine("Серия должна состаять из 2 букв верхнего регистра и 8 цифр!");
                }
            }
        }
        public Student_card()
        {

        }
    }
}

