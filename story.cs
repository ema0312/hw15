using System;
using System.Collections.Generic;
using System.Text;

namespace homework15
{
    class Story
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It was lovely summer weather in Milwaukee, and a father and son were enjoying a cruise in the city.");
            Console.ReadKey();

            Console.WriteLine("All of a sudden the father favorite song came on!");
            Console.ReadKey();

            Console.WriteLine("The son grin and asked father when you were young what was your nickname?");
            Console.ReadKey();

            Console.Write("The father responded....my nickname was [enter name]");
            string fatherName = Console.ReadLine();

            Father storyFather = new Father(fatherName, 38);

            int age = storyFather._age; 
            
            storyFather._age = 38;

            Console.WriteLine("Unique Son: Yeah, {0}. Is funny, that nickname describes you!", storyFather._nickName);
            Console.ReadKey();

            Console.Write("{0}: Do you have a nickname, mijo what is it ?[enter name]", storyFather._nickName);
            string mijo = Console.ReadLine();

            Console.WriteLine("{0}; My nickname is {0}: Now you know,", mijo);
            
        }
    }
}

