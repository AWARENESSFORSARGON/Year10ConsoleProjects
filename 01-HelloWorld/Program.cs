using System;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Output 'Hello World!' to the console screen by using 'Console.WriteLine();'
            Console.WriteLine("Hello World");

            // 2. Make the program wait for input by using 'Console.ReadLine();'
            Console.ReadLine();
        
           Console.WriteLine("Hey Man");
           Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Green");
            Console.ReadLine();

            Console.Beep(1000, 100);
            Console.Beep(1500, 100);
            Console.Beep(2000, 100);
            Console.Beep(2500, 100);
            Console.Beep(3000, 100);
            Console.Beep(2500, 100);
            Console.Beep(2000, 100);
            Console.Beep(1500, 100);
            Console.Beep(1000, 100);

        }
       

    }
}


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Output another message/pause after the ReadLine
2. Research online how to change the colour and/or make the console beep


QUESTIONS:
        
1. What is the difference between input and output?




WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers

/ ------------------------------------------------------------------------------------------ */