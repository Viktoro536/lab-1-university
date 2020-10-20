using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    class Identification_code
    {
        string code { set; get; }
        public string Code
        {
            get
            {
                return this.code;
            }
            set
            {
                string pattern = @"[0-9+$]{10}\b";
                string[] ser = Regex.Split(value, "id code: ");
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.code = ser[1];
                }
                else
                {
                    Console.WriteLine("Идентификационный код должен состоять из 10 цифр!");
                }
            }
        }
        public string GetCode()
        {
            return this.code;
        }
        public void SetCode(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[0-9+$]{10}\b";
                string[] ser = Regex.Split(value, "id code: ");
                Regex series = new Regex(pattern);
                string[] s = Regex.Split(ser[1], " ");
                if (series.IsMatch(s[0]))
                {
                    this.code = s[0];
                }
                else
                {
                    Console.WriteLine("Идентификационный код должен состоять из 10 цифр!");
                }
            }
            else
            {
                string pattern = @"[0-9+$]{10}\b";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.code = value;
                }
                else
                {
                    Console.WriteLine("Идентификационный код должен состоять из 10 цифр!");
                }
            }
        }
        public Identification_code(string value, bool setFile)
        {
            if (setFile)
            {
                string pattern = @"[0-9+$]{10}\b";
                string[] ser = Regex.Split(value, "id code: ");
                Regex series = new Regex(pattern);
                string[] s = Regex.Split(ser[1], " ");
                if (series.IsMatch(s[0]))
                {
                    this.code = s[0];
                }
                else
                {
                    Console.WriteLine("Идентификационный код должен состоять из 10 цифр!");
                }
            }
            else
            {
                string pattern = @"[0-9+$]{10}\b";
                Regex series = new Regex(pattern);
                if (series.IsMatch(value))
                {
                    this.code = value;
                }
                else
                {
                    Console.WriteLine("Идентификационный код должен состоять из 10 цифр!");
                }
            }
        }
        public Identification_code()
        {
            this.code = null;
        }
    }
}
