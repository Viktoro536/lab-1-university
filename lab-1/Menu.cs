using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Lab1;

namespace Lab1
{
    class WriteBase
    {
        public void writeBase(ref Student student, string @nameof)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string file = read.ReadToEnd();
            read.Close();
            rFile.Close();
            if (file == "")
            {
                FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Open, FileAccess.Write);
                StreamWriter writer = new StreamWriter(wFile);

                string data = "Student " + @nameof +
                               "\n{name: " + student.GetName() +
                               "\nsurname: " + student.GetSurname() +
                               "\ncourse: " + student.Course +
                               "\nhobby: " + student.GetHobby() +
                               "\nstudent card: " + student.Get_stud_card() +
                               "\nid code: " + student.Get_id_code() + " }\n\n";
                writer.Write(data);
                writer.Close();
                wFile.Close();
            }
            else
            {
                FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Append, FileAccess.Write);

                StreamWriter writer = new StreamWriter(wFile);

                string data = "Student " + @nameof +
                               "\n{name: " + student.GetName() +
                               "\nsurname: " + student.GetSurname() +
                               "\ncourse: " + student.Course +
                               "\nhobby: " + student.GetHobby() +
                               "\nstudent card: " + student.Get_stud_card() +
                               "\nid code: " + student.Get_id_code() + " }\n\n";
                writer.WriteLine(data);
                writer.Close();
                wFile.Close();
            }

        }
        public void writeBase(ref Courier courier, string @nameof)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string file = read.ReadToEnd();
            read.Close();
            rFile.Close();
            if (file == "")
            {
                FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Open, FileAccess.Write);
                StreamWriter writer = new StreamWriter(wFile);

                string data = "Courier " + @nameof +
                               "\n{name: " + courier.GetName() +
                               "\nsurname: " + courier.GetSurname() +
                               "\nproduct: " + courier.GetProduct() +
                               "\nhobby: " + courier.GetHobby() +
                               "\ndelivery address: " + courier.Get_delivery_address() +
                               "\nid code: " + courier.Get_id_code() + " }\n\n";
                writer.Write(data);
                writer.Close();
                wFile.Close();
            }
            else
            {
                FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(wFile);

                string data = "Courier " + @nameof +
                               "\n{name: " + courier.GetName() +
                               "\nsurname: " + courier.GetSurname() +
                               "\nproduct: " + courier.GetProduct() +
                               "\nhobby: " + courier.GetHobby() +
                               "\ndelivery address: " + courier.Get_delivery_address() +
                               "\nid code: " + courier.Get_id_code() + " }\n\n";
                writer.Write(data);
                writer.Close();
                wFile.Close();
            }



        }
        public void writeBase(ref Fireman fireman, string @nameof)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string file = read.ReadToEnd();
            read.Close();
            rFile.Close();
            if (file == "")
            {
                FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Open, FileAccess.Write);
                StreamWriter writer = new StreamWriter(wFile);

                string data = "Fireman " + @nameof +
                               "\n{name: " + fireman.GetName() +
                               "\nsurname: " + fireman.GetSurname() +
                               "\nfireman certificate number: " + fireman.GetFireman_certificate_number() +
                               "\nhobby: " + fireman.GetHobby() +
                               "\ncall address: " + fireman.Get_call_address() +
                               "\nid code: " + fireman.Get_id_code() + " }\n\n";
                writer.Write(data);
                writer.Close();
                wFile.Close();
            }
            else
            {
                FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(wFile);

                string data = "Fireman " + @nameof +
                               "\n{name: " + fireman.GetName() +
                               "\nsurname: " + fireman.GetSurname() +
                               "\nfireman certificate number: " + fireman.GetFireman_certificate_number() +
                               "\nhobby: " + fireman.GetHobby() +
                               "\ncall address: " + fireman.Get_call_address() +
                               "\nid code: " + fireman.Get_id_code() + " }\n\n";
                writer.Write(data);
                writer.Close();
                wFile.Close();
            }



        }
        public WriteBase(ref Student student, string @nameof)
        {
            this.writeBase(ref student, @nameof);
        }
        public WriteBase()
        {

        }
        ~WriteBase()
        {

        }
    }
    class ReadBase
    {
        public void readBaseStudent(ref Student S)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string[] obj = Regex.Split(data, pattern_split);
                string[] per = Regex.Split(obj[0], "\n");
                Regex Student_ = new Regex(@"^Student");
                if (Student_.IsMatch(per[0]))
                {
                    S = new Student(per[1], per[2], per[3], per[4], per[5], per[6], true);

                    read.Close();
                    rFile.Close();
                    FileInfo file = new FileInfo(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt");
                    file.Delete();
                    FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(wFile);
                    if (obj.Length <= 1)
                    {
                        writer.Write("");
                    }
                    else
                    {
                        for (int j = 1; j < obj.Length; j++)
                        {
                            writer.Write(obj[j] + "\n\n");
                        }
                    }
                    writer.Close();
                    wFile.Close();
                }
            }
            read.Close();
            rFile.Close();
        }
        public void readBaseCourier(ref Courier C)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string[] obj = Regex.Split(data, pattern_split);
                string[] per = Regex.Split(obj[0], "\n");
                Regex Courier_ = new Regex(@"^Courier");
                if (Courier_.IsMatch(per[0]))
                {
                    C = new Courier(per[1], per[2], per[3], per[4], per[5], per[6], true);

                    read.Close();
                    rFile.Close();
                    FileInfo file = new FileInfo(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt");
                    file.Delete();
                    FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(wFile);
                    if (obj.Length <= 1)
                    {
                        writer.Write("");
                    }
                    else
                    {
                        for (int j = 1; j < obj.Length; j++)
                        {
                            writer.Write(obj[j] + "\n\n");
                        }
                    }
                    writer.Close();
                    wFile.Close();
                }
            }
            read.Close();
            rFile.Close();
        }
        public void readBaseFireman(ref Fireman F)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string[] obj = Regex.Split(data, pattern_split);
                string[] per = Regex.Split(obj[0], "\n");
                Regex Fireman_ = new Regex(@"^Fireman");
                if (Fireman_.IsMatch(per[0]))
                {
                    F = new Fireman(per[1], per[2], per[3], per[4], per[5], per[6], true);

                    read.Close();
                    rFile.Close();
                    FileInfo file = new FileInfo(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt");
                    file.Delete();
                    FileStream wFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(wFile);
                    if (obj.Length <= 1)
                    {
                        writer.Write("");
                    }
                    else
                    {
                        for (int j = 1; j < obj.Length; j++)
                        {
                            writer.Write(obj[j] + "\n\n");
                        }
                    }
                    writer.Close();
                    wFile.Close();
                }
            }
            read.Close();
            rFile.Close();
        }
        public ReadBase()
        {

        }
    }
    class ReadFile_elements
    {
        public int Calc()
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string[] obj = Regex.Split(data, pattern_split);
                read.Close();
                rFile.Close();
                return obj.Length;
            }
        }
        public int[] Who()
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                int[] whoIS = new int[obj.Length];
                Regex Student_ = new Regex(@"Student");
                Regex Courier_ = new Regex(@"Courier");
                Regex Fireman_ = new Regex(@"Fireman");
                for (int i = 0; i < obj.Length; i++)
                {
                    string[] str = Regex.Split(obj[i], pattern_split_str);

                    if (str.Length <= 6)
                    {
                        continue;
                    }
                    else
                    {
                        if (Student_.IsMatch(str[0]) || Student_.IsMatch(str[1]) || Student_.IsMatch(str[2]) || Student_.IsMatch(str[3]))
                        {
                            whoIS[i] = 1;
                        }
                        else
                        {
                            if (Courier_.IsMatch(str[0]) || Courier_.IsMatch(str[1]) || Courier_.IsMatch(str[2]) || Courier_.IsMatch(str[3]))
                            {
                                whoIS[i] = 2;
                            }
                            else
                            {
                                if (Fireman_.IsMatch(str[0]) || Fireman_.IsMatch(str[1]) || Fireman_.IsMatch(str[2]) || Fireman_.IsMatch(str[3]))
                                {
                                    whoIS[i] = 3;
                                }
                                else
                                {
                                    read.Close();
                                    rFile.Close();
                                    continue;
                                }
                            }
                        }
                    }
                }

                read.Close();
                rFile.Close();
                return whoIS;
            }
        }
        public void Stud(ref Student[] S, int s)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Append, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                Regex Student_ = new Regex(@"^Student");
                S = new Student[s];
                for (int i = 0; i < obj.Length; i++)
                {
                    string[] str = Regex.Split(obj[i], pattern_split_str);
                    if (Student_.IsMatch(str[0]))
                    {
                        for (int j = 0; j < s; j++)
                        {
                            if (S[j] == null)
                            {
                                S[j] = new Student(str[1], str[2], str[3], str[4], str[5], str[6], true);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                read.Close();
                rFile.Close();
            }
        }
        public void Cour(ref Courier[] C, int c)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Append, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                Regex Courier_ = new Regex(@"^Courier");
                C = new Courier[c];
                for (int i = 0; i < obj.Length; i++)
                {
                    string[] str = Regex.Split(obj[i], pattern_split_str);
                    if (Courier_.IsMatch(str[0]))
                    {
                        for (int j = 0; j < c; j++)
                        {
                            if (C[j] == null)
                            {
                                C[j] = new Courier(str[1], str[2], str[3], str[4], str[5], str[6], true);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                read.Close();
                rFile.Close();
            }
        }
        public void Fire(ref Fireman[] F, int f)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.Append, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                Regex Fireman_ = new Regex(@"^Fireman");
                F = new Fireman[f];
                for (int i = 0; i < obj.Length; i++)
                {
                    string[] str = Regex.Split(obj[i], pattern_split_str);
                    if (Fireman_.IsMatch(str[0]))
                    {
                        for (int j = 0; j < f; j++)
                        {
                            if (F[j] == null)
                            {
                                F[j] = new Fireman(str[1], str[2], str[3], str[4], str[5], str[6], true);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                read.Close();
                rFile.Close();
            }

        }
        public void Stud_(ref Student[] S, int s)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                Regex Student_ = new Regex(@"Student");
                S = new Student[s];
                int void_ = 0;
                for (int i = 0; i < obj.Length; i++)
                {
                    string objj = obj[i];
                    string[] str = Regex.Split(objj, pattern_split_str);
                    if (str.Length >= 6)
                    {
                        if (Student_.IsMatch(str[0]) || Student_.IsMatch(str[1]) || Student_.IsMatch(str[2]) || Student_.IsMatch(str[3]))
                        {
                            int bad_string_index = 0;
                            while (!Student_.IsMatch(str[bad_string_index]))
                            {
                                str[bad_string_index] = null;
                                bad_string_index++;
                            }
                            string[] buf_str = new string[str.Length - bad_string_index];
                            for (int q = 0; q < buf_str.Length; q++)
                            {
                                buf_str[q] = str[bad_string_index + q];
                            }
                            for (int j = void_; j < s; j++)
                            {
                                if (S[j] == null)
                                {
                                    S[j] = new Student(buf_str[1], buf_str[2], buf_str[3], buf_str[4], buf_str[5], buf_str[6], true);
                                    void_++;
                                }
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                }

                read.Close();
                rFile.Close();
            }
        }
        public void Cour_(ref Courier[] C, int c)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                Regex Courier_ = new Regex(@"Courier");
                C = new Courier[c];
                int void_ = 0;
                for (int i = 0; i < obj.Length; i++)
                {
                    string objj = obj[i];
                    string[] str = Regex.Split(objj, pattern_split_str);
                    if (str.Length >= 6)
                    {
                        if (Courier_.IsMatch(str[0]) || Courier_.IsMatch(str[1]) || Courier_.IsMatch(str[2]) || Courier_.IsMatch(str[3]))
                        {
                            int bad_string_index = 0;
                            while (!Courier_.IsMatch(str[bad_string_index]))
                            {
                                str[bad_string_index] = null;
                                bad_string_index++;
                            }
                            string[] buf_str = new string[str.Length - bad_string_index];
                            for (int q = 0; q < buf_str.Length; q++)
                            {
                                buf_str[q] = str[bad_string_index + q];
                            }
                            for (int j = void_; j < c; j++)
                            {
                                if (C[j] == null)
                                {
                                    C[j] = new Courier(buf_str[1], buf_str[2], buf_str[3], buf_str[4], buf_str[5], buf_str[6], true);
                                    void_++;
                                }
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                }

                read.Close();
                rFile.Close();
            }
        }
        public void Fire_(ref Fireman[] F, int f)
        {
            FileStream rFile = new FileStream(@"D:\Универ\Курс 2\ООП\Lab1\database\database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader read = new StreamReader(rFile);
            string data = read.ReadToEnd();
            if (data == "")
            {
                read.Close();
                rFile.Close();
                throw new Exception("Файл пуст, чтение не возможно!");
            }
            else
            {
                string pattern_split = "\n\n";
                string pattern_split_str = "\n";
                string[] obj = Regex.Split(data, pattern_split);
                Regex Fireman_ = new Regex(@"Fireman");
                F = new Fireman[f];
                int void_ = 0;
                for (int i = 0; i < obj.Length; i++)
                {
                    string objj = obj[i];
                    string[] str = Regex.Split(objj, pattern_split_str);
                    if (str.Length >= 6)
                    {
                        if (Fireman_.IsMatch(str[0]) || Fireman_.IsMatch(str[1]) || Fireman_.IsMatch(str[2]) || Fireman_.IsMatch(str[3]))
                        {
                            int bad_string_index = 0;
                            while (!Fireman_.IsMatch(str[bad_string_index]))
                            {
                                str[bad_string_index] = null;
                                bad_string_index++;
                            }
                            string[] buf_str = new string[str.Length - bad_string_index];
                            for (int q = 0; q < buf_str.Length; q++)
                            {
                                buf_str[q] = str[bad_string_index + q];
                            }
                            for (int j = void_; j < f; j++)
                            {
                                if (F[j] == null)
                                {
                                    F[j] = new Fireman(buf_str[1], buf_str[2], buf_str[3], buf_str[4], buf_str[5], buf_str[6], true);
                                    void_++;
                                }
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
                read.Close();
                rFile.Close();
            }

        }
        public ReadFile_elements()
        {

        }
    }
}
