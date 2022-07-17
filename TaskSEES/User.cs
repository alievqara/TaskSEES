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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }

        public int Mounth { get; set; }


        enum RegistrationMonth
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

        public User() => id++;

        public string CheckNotRobotCode(string NotRobotCode)
        {
            this.NotRobotCode = NotRobotCode;

            if (NotRobotCode.Length != 4)
            {
                return "NotRobotCode Düzgün Göndərilməyib";

            }
            else
            {
                return NotRobotCode;
            }

        }


        public void GetDetail()
        {
            Console.WriteLine($"User ID: {id}, Name: {Name}, Surname: {Surname}, NotRobotCode: {CheckNotRobotCode(NotRobotCode)}, Registration Month: {Mounth}");


            //switch (Mounth)
            //{
            //    case (int)RegistrationMonth.January:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.February:
            //        return;           
            //        break;
            //    case (int)RegistrationMonth.March:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.April:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.May:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.June:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.July:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.August:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.September:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.October:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.November:
            //        return;
            //        break;
            //    case (int)RegistrationMonth.December:
            //        return;
            //        break;

            //    default:
            //        break;
            //}


        }





    }


}
