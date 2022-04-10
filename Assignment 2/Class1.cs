using System;

namespace Assignment_2
{
    public class MobilePhoneTransitionEra
    {
        public static string Era1;
        public static string Era2;
        public static string Era3;
        public static string presentEra;

        public string FirstEra
        {
            get { return Era1; }
            set { Era1 =  "call and text messeges"; } 
        }
        public string SecondEra
        {
            get { return Era2; }
            set { Era2 = "camera and video MMS"; }
        }
        public string ThirdEra
        {
            get { return Era3; }

            set { Era3 = "emails and games"; }
        }

        public string PresentEra
        {
            get { return Era1 + Era2 + Era3; }
            set { presentEra = Era1 + Era2 + Era3; }
        }
    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("The first mobile phone era transition can be seen as:");
            Console.WriteLine(MobilePhoneTransitionEra.Era1);
            Console.WriteLine(" ");
            Console.WriteLine("The second mobile phone era transition can be seen as:");
            Console.WriteLine(MobilePhoneTransitionEra.Era2);
            Console.WriteLine(" ");
            Console.WriteLine("The third mobile phone era transition can be seen as:");
            Console.WriteLine(MobilePhoneTransitionEra.Era3);
            Console.WriteLine(" ");
            Console.WriteLine("The present mobile phone era can be seen as:");
            Console.WriteLine(MobilePhoneTransitionEra.presentEra);
            Console.WriteLine();
        }
    }
}
