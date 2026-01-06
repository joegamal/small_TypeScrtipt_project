using System;

public class Menue
{
    public static void StudOrTet()
    {
        Console.WriteLine("for student press 1 \n for teacher press 2 \n");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            StudentMenue();
        }
        else
        {
            TeacherMenue();
        }

    }



    public static void StudentMenue()
    {
        //print the header
        StudentHelperMeothods.StudentMenueHeader();

        string answer = Console.ReadLine();

        answer = answer.ToLower();

        StudentHelperMeothods.StudentMenueAction(answer);

    }


    public static void TeacherMenue()
    {
        //print the header
        TeacherHelperMethods.TeacherMenueHeader();

        string answer = Console.ReadLine(); 

        answer = answer.ToLower(); 

        TeacherHelperMethods.TeacherMenueAction(answer);
    }
}