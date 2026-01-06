using System;

public class Main_entry_point
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to exam system");


        bool alive = true;
        while (alive)
        {
            Console.WriteLine("for menue press 1\n");
            Console.WriteLine("to exit press 0\n");
            int answer = int.Parse(Console.ReadLine());

            if(answer == 0)
            {
                Environment.Exit(0);
            }
            else if (answer == 1)
            {
                Menue.StudOrTet();
            }

        }
    }
}