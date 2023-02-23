


public class Program
{
    public static void Main()
    {

        string fName, mName, lName, fullName; 
        Console.WriteLine("Enter your First Name ");
        fName = Console.ReadLine();

        Console.WriteLine("Enter your Middle Name ");
        mName = Console.ReadLine();

        Console.WriteLine("Enter your Last Name ");
        lName = Console.ReadLine();

        fullName = fName + " " + mName + " " + lName;
        Console.WriteLine(fullName);

        var str = Console.ReadLine();
        Console.WriteLine(str);
    }
}
