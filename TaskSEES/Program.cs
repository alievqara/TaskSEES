using System;

namespace TaskSEES
{
    public class Program
    {
        public static void Main()
        {



            User user1 = new User("Faiq", "Aliyev", "1313", Month.January);
            Console.WriteLine(user1.GetDetail());

            User user2 = new User("Tamerlan", "Aliyev", "13H53", Month.August);
            Console.WriteLine(user2.GetDetail());

            User user3 = new User("Aylin", "Aliyeva", "13FA", Month.August);
            Console.WriteLine(user3.GetDetail());

            User user4 = new User("Faiq", "Aliyev", "13JU13", Month.May);
            Console.WriteLine(user4.GetDetail());

            User user5 = new User("Faiq", "Aliyev", "1313", Month.January);
            Console.WriteLine(user5.GetDetail());











        }


    }

}










