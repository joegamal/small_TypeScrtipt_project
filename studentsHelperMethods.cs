

public class StudentHelperMeothods
{
    public static void ShowStudentGrades()
    {
        
    }

    public static void ShowStudentSubjects()
    {
        
    }

    public static void ShowStudentMentors()
    {
        
    }

    public static void AddSubject()
    {
        
    }

    public static void DropSubject()
    {
        
    }

    public static void StudentMenueHeader()
    {
        System.Console.WriteLine("for grade press G");
        System.Console.WriteLine("for subjects press S");
        System.Console.WriteLine("for mentors press M");
        System.Console.WriteLine("to add a new subject type add");
        System.Console.WriteLine("to drop a subject type drop");
    }

    public static void StudentMenueAction(string answer)
    {
        switch (answer)
        {
            case "G":
                StudentHelperMeothods.ShowStudentGrades();
                break;

            case "S":
                StudentHelperMeothods.ShowStudentSubjects();
                break;

            case "M":
                StudentHelperMeothods.ShowStudentMentors();
                break;

            case "add":
                StudentHelperMeothods.AddSubject();
                break;

            case "drop":
                StudentHelperMeothods.DropSubject();
                break;

            default:
                System.Console.WriteLine("not supported");
                break;
        }
    }
}