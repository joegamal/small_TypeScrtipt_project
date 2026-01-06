
using System;

public class TeacherHelperMethods
{
    public static void ViewStudents()
    {
        
    }


    public static void DropStudent()
    {
        
    }

    public static void ViewStudentGrades()
    {
        
    }


    public static void TeacherMenueHeader()
    { 
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. View all students");
        Console.WriteLine("2. Drop a student");
        Console.WriteLine("3. View student grades");
    }

    public static void TeacherMenueAction(string answer)
    {
        switch (answer)
        {
            case "1":
            case "view":
                ViewStudents();
                break;

            case "2":
            case "drop":
                DropStudent();
                break;

            case "3":
            case "grades":
                ViewStudentGrades();
                break;
            case "4":
            
            default:
                Console.WriteLine("Invalid option. Try again."); 
                break;
        }
    }

}