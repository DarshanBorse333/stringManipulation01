


public class Program
{
    public static void Main()
    {

        //string fName, mName, lName, fullName; 
        //Console.WriteLine("Enter your First Name ");
        //fName = Console.ReadLine();

        //Console.WriteLine("Enter your Middle Name ");
        //mName = Console.ReadLine();

        //Console.WriteLine("Enter your Last Name ");
        //lName = Console.ReadLine();

        //fullName = fName + " " + mName + " " + lName;
        //Console.WriteLine(fullName);




        //Calculate lenght of the string

        //Console.WriteLine("Enter any string :");
        //var str = Console.ReadLine();

        //int counter = 0;

        //foreach (var item in str)
        //{
        //    counter++;
        //}

        //Console.WriteLine("length of character is = "+counter);



        //caluculate the vowels from the string

        Console.WriteLine("Please Enter any string : ");
        var str = Console.ReadLine();

        int vowelsCounter = 0;

        foreach (var item in str)
        {
            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
            {
                vowelsCounter++;
            }

        }
            Console.WriteLine("total number of vowels are : " + vowelsCounter);
        
    }
}
