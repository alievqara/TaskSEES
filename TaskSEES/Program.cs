using System;

namespace TaskSEES
{
    public class Program
    {
        public static void Main()
        {

            

            User user1 = new User();
            user1.Name = "Faiq";
            user1.Surname = "Aliyev";
            user1.NotRobotCode = "1313";
            user1.Mounth = 2;

            user1.GetDetail();




            User user2 = new User();
            user2.Name = "Tamerlan";
            user2.Surname = "Aliyev";
            user2.NotRobotCode = "1413";
            user2.Mounth = 5;

            user2.GetDetail();



            User user3 = new User();
            user3.Name = "Aylin";
            user3.Surname = "Aliyeva";
            user3.NotRobotCode = "15513";
            user3.Mounth = 12;


            user3.GetDetail();



            User user4 = new User();
            user4.Name = "Teymurleng";
            user4.Surname = "Aliyev";
            user4.NotRobotCode = "1613";
            user4.Mounth = 11;

            user4.GetDetail();



            User user5 = new User();
            user5.Name = "Cingiz";
            user5.Surname = "Xan";
            user5.NotRobotCode = "173513";
            user5.Mounth = 1;

            user5.GetDetail();












        }


    }

}










