using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSEES
{
    public class User
    {

        private static int id { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }

        public Month RegistrationMounth { get; set; }



        public User(string name, string surname, string notRobotCode, Month registrationMounth)
        {
            Name = name;
            Surname = surname;
            NotRobotCode = notRobotCode;
            RegistrationMounth = registrationMounth;

            id++;
            ID = id;
        }

        


        public string GetDetail()
        {
            if (NotRobotCode.CheckNotRobotCode())
            {
            return $"User ID: {id}, Name: {Name}, Surname: {Surname}, NotRobotCode: {NotRobotCode}, Registration Month: {RegistrationMounth}";


            }
            else
            {
                return $"User ID: {id}, Name: {Name}, Surname: {Surname}, NotRobotCode Düzgün Göndərilməyib , Registration Month: {RegistrationMounth}";
               

            }

          

        }





    }
    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }


}
