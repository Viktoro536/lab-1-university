using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab1
{
    
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();

        static string path_database = @"D:\Универ\Курс 2\ООП\Lab1\database\database.txt";        
        static async Task Main(string[] args)
        {

            //WriteBase write = new WriteBase();

            //Courier Vova = new Courier("Vova", "Popruzhenko", "13452134", "Game", "проспектПобеды103", "0000000000");
            //write.writeBase(ref Vova, nameof(Vova));
            //Courier Lena = new Courier("Lena", "Kihinas", "13452133", "Walk", "проспектПобеды105", "0000000001");
            //write.writeBase(ref Lena, nameof(Lena));
            //Courier Kira = new Courier("Kira", "Lonera", "1", "Smoke", "проспектПобеды108", "0000000002");
            //write.writeBase(ref Kira, nameof(Kira));

            //Student Olga = new Student("Olga", "Popruzhenko", "2", "Walk", "KV12432000", "0101010101");
            //write.writeBase(ref Olga, nameof(Olga));
            //Student Olena = new Student("Olena", "Kazpiv", "3", "Read", "KV12432001", "0101010102");
            //write.writeBase(ref Olena, nameof(Olena));
            //Student Kirill = new Student("Kirill", "Gropin", "1", "Game", "KV12432002", "0101010103");
            //write.writeBase(ref Kirill, nameof(Kirill));

            //Fireman Alex = new Fireman("Alex", "Khomenko", "9823512", "Read", "проспектМеталургов14", "9999999999");
            //write.writeBase(ref Alex, nameof(Alex));
            //Fireman Gena = new Fireman("Gena", "Lemka", "9872357", "Walk", "проспектМеталургов76", "9999999934");
            //write.writeBase(ref Gena, nameof(Gena));
            //Fireman Roma = new Fireman("Roma", "Korunka", "9876324", "Game", "проспектМеталургов19", "9999999921");
            //write.writeBase(ref Roma, nameof(Roma));


            ConsoleMenu CM = new ConsoleMenu();
            WriteBase writeFile = new WriteBase();
            ReadBase readFile = new ReadBase();
            ReadFile_elements num = new ReadFile_elements();
            Student[] S = null;
            Courier[] C = null;
            Fireman[] F = null;
            int[] WhoIs = null;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("Прочесть файл, нажмите <r>.");
                    Console.WriteLine("Чтобы использовать возможности ниже, прочтите файл!");
                    Console.WriteLine("Добавить объект, нажмите <a>");
                    Console.WriteLine("Удалить объект, нажмите <d>");
                    Console.WriteLine("Сохранить и выйти, нажмите <s>");
                    Console.WriteLine("Выйти без сохранения, нажмите <e>, возможна потеря данных!");
                    switch (_getch())
                    {
                        case 'r':
                            {
                                WhoIs = num.Who();
                                int s, c, f; s = c = f = 0;
                                for (int i = 0; i < WhoIs.Length; i++)
                                {
                                    switch (WhoIs[i])
                                    {
                                        case 1: s++; break;
                                        case 2: c++; break;
                                        case 3: f++; break;
                                        default:
                                            break;
                                    }
                                }
                                num.Stud_(ref S, s);
                                num.Cour_(ref C, c);
                                num.Fire_(ref F, f);
                                Console.WriteLine("\n");
                                for (int i = 0; i < s; i++)
                                {
                                    CM.readConsoleStudent(ref S[i]);
                                }
                                for (int i = 0; i < c; i++)
                                {
                                    CM.readConsoleCourier(ref C[i]);
                                }
                                for (int i = 0; i < f; i++)
                                {
                                    CM.readConsoleFireman(ref F[i]);
                                }

                                FileInfo file = new FileInfo(path_database);
                                file.Delete();
                                if ((S == null && C == null && F == null))
                                {
                                    System.Environment.Exit(0);
                                }
                                for (int i = 0; i < S.Length; i++)
                                {
                                    if (S[i] != null)
                                    {
                                        writeFile.writeBase(ref S[i], S[i].GetName() + S[i].GetSurname());
                                    }
                                }
                                for (int i = 0; i < C.Length; i++)
                                {
                                    if (C[i] != null)
                                    {
                                        writeFile.writeBase(ref C[i], C[i].GetName() + C[i].GetSurname());
                                    }
                                }
                                for (int i = 0; i < F.Length; i++)
                                {
                                    if (F[i] != null)
                                    {
                                        writeFile.writeBase(ref F[i], F[i].GetName() + F[i].GetSurname());
                                    }
                                }
                            }
                            break;
                        case 'a':
                            {
                                Console.WriteLine("\nКого хотите добавить?\n1. Student - нажмите 1\n2. Courier - нажмите 2\n3. Fireman - нажмите 3");
                                switch (_getch())
                                {
                                    case '1':
                                        {
                                            Student new_ = new Student();
                                            Console.WriteLine("Введите имя:");
                                            do
                                            {
                                                new_.SSetName(Console.ReadLine(), false);
                                            } while (new_.GetName() == null);
                                            Console.WriteLine("Введите фамилию:");
                                            do
                                            {
                                                new_.SSetSurname(Console.ReadLine(), false);
                                            } while (new_.GetSurname() == null);
                                            Console.WriteLine("Введите хобби:");
                                            do
                                            {
                                                new_.SSetHobby(Console.ReadLine(), false);
                                            } while (new_.GetHobby() == null);
                                            Console.WriteLine("Введите курс:");
                                            do
                                            {
                                                new_.SetCourse(Console.ReadLine(), false);
                                            } while (new_.Course == null);
                                            Console.WriteLine("Введите серию и номер студенчиского билета:");
                                            do
                                            {
                                                new_.SetSt_card(Console.ReadLine(), false);
                                            } while (new_.Get_stud_card() == null);
                                            Console.WriteLine("Введите идентификационный код:");
                                            do
                                            {
                                                new_.SetId_code(Console.ReadLine(), false);
                                            } while (new_.Get_id_code() == null);

                                            Console.WriteLine("\n");

                                            CM.readConsoleStudent(ref new_);
                                            int mas_arr = S.Length + 1;
                                            Student[] Buf = new Student[mas_arr];
                                            for (int i = 0; i < mas_arr; i++)
                                            {
                                                if (i == mas_arr -1)
                                                {
                                                    Buf[i] = new_;
                                                }
                                                else
                                                {
                                                    Buf[i] = S[i];
                                                }
                                            }

                                            S = new Student[mas_arr];
                                            for (int i = 0; i < mas_arr; i++)
                                            {
                                                S[i] = Buf[i];
                                            }
                                            Console.WriteLine("\nОбъект добавлен.\n");
                                        }
                                        break;
                                    case '2':
                                        {
                                            Courier new_ = new Courier();
                                            Console.WriteLine("Введите имя:");
                                            do
                                            {
                                                new_.SSetName(Console.ReadLine(), false);
                                            } while (new_.GetName() == null);

                                            Console.WriteLine("Введите фамилию:");
                                            do
                                            {
                                                new_.SSetSurname(Console.ReadLine(), false);
                                            } while (new_.GetSurname() == null);

                                            Console.WriteLine("Введите хобби:");
                                            do
                                            {
                                                new_.SSetHobby(Console.ReadLine(), false);
                                            } while (new_.GetHobby() == null);

                                            Console.WriteLine("Введите номер продукта:");
                                            do
                                            {
                                                new_.SetProduct(Console.ReadLine(), false);
                                            } while (new_.GetProduct() == null);

                                            Console.WriteLine("Введите адрес доставки:");
                                            do
                                            {
                                                new_.SetDelivery_address(Console.ReadLine(), false);
                                            } while (new_.Get_delivery_address() == null);

                                            Console.WriteLine("Введите идентификационный код:");
                                            do
                                            {
                                                new_.SetId_code(Console.ReadLine(), false);
                                            } while (new_.Get_id_code() == null);

                                            Console.WriteLine("\n");

                                            CM.readConsoleCourier(ref new_);
                                            int mas_arr = C.Length + 1;
                                            Courier[] Buf = new Courier[mas_arr];
                                            for (int i = 0; i < mas_arr; i++)
                                            {
                                                if (i == mas_arr - 1)
                                                {
                                                    Buf[i] = new_;
                                                }
                                                else
                                                {
                                                    Buf[i] = C[i];
                                                }
                                            }

                                            C = new Courier[mas_arr];
                                            for (int i = 0; i < mas_arr; i++)
                                            {
                                                C[i] = Buf[i];
                                            }
                                            Console.WriteLine("\nОбъект добавлен.\n");
                                        }
                                        break;
                                    case '3':
                                        {
                                            Fireman new_ = new Fireman();
                                            Console.WriteLine("Введите имя:");
                                            do
                                            {
                                                new_.SSetName(Console.ReadLine(), false);
                                            } while (new_.GetName() == null);

                                            Console.WriteLine("Введите фамилию:");
                                            do
                                            {
                                                new_.SSetSurname(Console.ReadLine(), false);
                                            } while (new_.GetSurname() == null);

                                            Console.WriteLine("Введите хобби:");
                                            do
                                            {
                                                new_.SSetHobby(Console.ReadLine(), false);
                                            } while (new_.GetHobby() == null);

                                            Console.WriteLine("Введите номер удостоверения пожарного:");
                                            do
                                            {
                                                new_.SetFireman_certificate_number(Console.ReadLine(), false);
                                            } while (new_.GetFireman_certificate_number() == null);

                                            Console.WriteLine("Введите адрес вызова:");
                                            do
                                            {
                                                new_.SetСall_address(Console.ReadLine(), false);
                                            } while (new_.Get_call_address() == null);

                                            Console.WriteLine("Введите идентификационный код:");
                                            do
                                            {
                                                new_.SetId_code(Console.ReadLine(), false);
                                            } while (new_.Get_id_code() == null);

                                            writeFile.writeBase(ref new_, new_.Name + new_.Surname);

                                            Console.WriteLine("\n");

                                            CM.readConsoleFireman(ref new_);
                                            int mas_arr = F.Length + 1;
                                            Fireman[] Buf = new Fireman[mas_arr];
                                            for (int i = 0; i < mas_arr; i++)
                                            {
                                                if (i == mas_arr - 1)
                                                {
                                                    Buf[i] = new_;
                                                }
                                                else
                                                {
                                                    Buf[i] = F[i];
                                                }
                                            }

                                            F = new Fireman[mas_arr];
                                            for (int i = 0; i < mas_arr; i++)
                                            {
                                                F[i] = Buf[i];
                                            }
                                            Console.WriteLine("\nОбъект добавлен.\n");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case 'd':
                            {
                                Console.WriteLine("\nКого хотите удалить?\n1. Student - нажмите 1\n2. Courier - нажмите 2\n3. Fireman - нажмите 3");
                                switch (_getch())
                                {
                                    case '1':
                                        {
                                            Console.WriteLine("Введите серию и номер студента, которого хотите удалить:");
                                            string code = Console.ReadLine();
                                            string pattern = @"[(^0-9)A-ZА-Я{2}]+[(^A-zА-я)0-9{8}\b]";
                                            Regex series = new Regex(pattern);
                                            int k = 0;
                                            int ar = S.Length;
                                            if (series.IsMatch(code))
                                            {
                                                for (int i = 0; i < S.Length; i++)
                                                {
                                                    if (S[i].Get_stud_card() == code)
                                                    {
                                                        S[i] = null;
                                                        k = i;
                                                        continue;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Серия должна состаять из 2 букв верхнего регистра и 8 цифр!");
                                            }
                                            S[k] = S[S.Length - 1];
                                            Student[] Buf = new Student[ar - 1];
                                            for (int i = 0; i < ar - 1; i++)
                                            {
                                                Buf[i] = S[i];
                                            }
                                            S = new Student[ar - 1];
                                            for (int i = 0; i < S.Length; i++)
                                            {
                                                S[i] = Buf[i];
                                            }
                                            Console.WriteLine("\nОбъект удален.");
                                        }
                                        break;
                                    case '2':
                                        {
                                            Console.WriteLine("Введите идентификационный код курьер, которого хотите удалить:");
                                            string code = Console.ReadLine();
                                            string pattern = @"[0-9+$]{10}\b";
                                            Regex series = new Regex(pattern);
                                            int k = 0;
                                            int ar = C.Length;
                                            if (series.IsMatch(code))
                                            {
                                                for (int i = 0; i < C.Length; i++)
                                                {
                                                    if (C[i].Get_id_code() == code)
                                                    {
                                                        C[i] = null;
                                                        k = i;
                                                        continue;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Идентификационный код должен состоять из 10 цифр!");
                                            }
                                            C[k] = C[C.Length - 1];
                                            Courier[] Buf = new Courier[ar - 1];
                                            for (int i = 0; i < ar - 1; i++)
                                            {
                                                Buf[i] = C[i];
                                            }
                                            C = new Courier[ar - 1];
                                            for (int i = 0; i < C.Length; i++)
                                            {
                                                C[i] = Buf[i];
                                            }
                                            Console.WriteLine("\nОбъект удален.");
                                        }
                                        break;
                                    case '3':
                                        {
                                            Console.WriteLine("Введите номер удостоверения пожарного, которого хотите удалить:");
                                            string code = Console.ReadLine();
                                            string pattern = @"\d+$";
                                            Regex series = new Regex(pattern);
                                            int k = 0;
                                            int ar = F.Length;
                                            if (series.IsMatch(code))
                                            {
                                                for (int i = 0; i < F.Length; i++)
                                                {
                                                    if (F[i].Get_id_code() == code)
                                                    {
                                                        F[i] = null;
                                                        k = i;
                                                        continue;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Номер удостоверения должен состоять из цифр!");
                                            }
                                            F[k] = F[F.Length - 1];
                                            Fireman[] Buf = new Fireman[ar - 1];
                                            for (int i = 0; i < ar - 1; i++)
                                            {
                                                Buf[i] = F[i];
                                            }
                                            F = new Fireman[ar - 1];
                                            for (int i = 0; i < F.Length; i++)
                                            {
                                                F[i] = Buf[i];
                                            }
                                            Console.WriteLine("\nОбъект удален.");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case 's':
                            {
                                FileInfo file = new FileInfo(path_database);
                                file.Delete();
                                if ((S == null && C == null && F == null))
                                {
                                    Console.WriteLine("\nСохранено.");
                                    System.Environment.Exit(0);
                                }
                                for (int i = 0; i < S.Length; i++)
                                {
                                    if (S[i] != null)
                                    {
                                        writeFile.writeBase(ref S[i], S[i].GetName() + S[i].GetSurname());
                                    }
                                }
                                for (int i = 0; i < C.Length; i++)
                                {
                                    if (C[i] != null)
                                    {
                                        writeFile.writeBase(ref C[i], C[i].GetName() + C[i].GetSurname());
                                    }
                                }
                                for (int i = 0; i < F.Length; i++)
                                {
                                    if (F[i] != null)
                                    {
                                        writeFile.writeBase(ref F[i], F[i].GetName() + F[i].GetSurname());
                                    }
                                }
                                Console.WriteLine("\nСохранено.");
                                System.Environment.Exit(0);
                            }
                            break;
                        case 'e':
                            System.Environment.Exit(0);
                            break;
                        default:
                            {
                                if ((S == null && C == null && F == null))
                                {
                                    System.Environment.Exit(0);
                                }
                                int s, c, f; s = c = f = 0;
                                for (int i = 0; i < WhoIs.Length; i++)
                                {
                                    switch (WhoIs[i])
                                    {
                                        case 1: s++; break;
                                        case 2: c++; break;
                                        case 3: f++; break;
                                        default:
                                            break;
                                    }
                                }
                                for (int i = 0; i < s; i++)
                                {
                                    if (S[i] != null)
                                    {
                                        writeFile.writeBase(ref S[i], S[i].GetName() + S[i].GetSurname());
                                    }
                                }
                                for (int i = 0; i < c; i++)
                                {
                                    if (C[i] != null)
                                    {
                                        writeFile.writeBase(ref C[i], C[i].GetName() + C[i].GetSurname());
                                    }
                                }
                                for (int i = 0; i < f; i++)
                                {
                                    if (F[i] != null)
                                    {
                                        writeFile.writeBase(ref F[i], F[i].GetName() + F[i].GetSurname());
                                    }
                                }
                                Console.WriteLine("\nСохранено.");
                                System.Environment.Exit(0);
                            }
                            break;
                    }
                }
                catch (Exception str)
                {
                    Console.WriteLine(str.Message);
                }
            }


        }

    }

}
