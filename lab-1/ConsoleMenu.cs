using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ConsoleMenu
    {
        public void readConsoleStudent(ref Student student)
        {
            string data = "Student " + student.GetName() + student.GetSurname()+
                               "\n{name: " + student.GetName() +
                               "\nsurname: " + student.GetSurname() +
                               "\ncourse: " + student.Course +
                               "\nhobby: " + student.GetHobby() +
                               "\nstudent card: " + student.Get_stud_card() +
                               "\nid code: " + student.Get_id_code() + " }\n\n";
            Console.WriteLine(data);
        }
        public void readConsoleCourier(ref Courier courier)
        {
            string data = "Courier " + courier.GetName() + courier.GetSurname()+
                               "\n{name: " + courier.GetName() +
                               "\nsurname: " + courier.GetSurname() +
                               "\nproduct: " + courier.GetProduct() +
                               "\nhobby: " + courier.GetHobby() +
                               "\ndelivery address: " + courier.Get_delivery_address() +
                               "\nid code: " + courier.Get_id_code() + " }\n\n";
            Console.WriteLine(data);
        }
        public void readConsoleFireman(ref Fireman fireman)
        {
            string data = "Fireman " + fireman.GetName() + fireman.GetSurname()+
                               "\n{name: " + fireman.GetName() +
                               "\nsurname: " + fireman.GetSurname() +
                               "\nfireman certificate number: " + fireman.GetFireman_certificate_number() +
                               "\nhobby: " + fireman.GetHobby() +
                               "\ncall address: " + fireman.Get_call_address() +
                               "\nid code: " + fireman.Get_id_code() + " }\n\n";
            Console.WriteLine(data);
        }
    }
}
