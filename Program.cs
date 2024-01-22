using System;

public class Vector
{

    int max = 0;
    string FNameMax, LNameMax;
    Date YearMax;
    int AgeMax;
    public class Persoana
    {
        string FirstName, LastName;
        Console.Write("Input a FirstName: ");
            FirstName = Console.ReadLine();
        Console.Write("Input a LastName: ");
            LastName = Console.ReadLine();
        DateTime YearOfBirth;
        YearOfBirth = Console.ReadLine();
        YearOfBirth = Console.ReadLine();
        int Age;
        Age = DateTime.Now.Year - YearOfBirth;
    }
    static void PersonProcessor
        {
            if (Age > max)
            {
                max = Age;
                FNameMax = FirstNane;
                LNameMax = LastName;
                YearMax = YearOfBirth;
                AgeMax = Age;
            }
    }
    Console.Write(FNameMax);
    Console.Write(LNameMax);
    Console.Write(YearMax);
    Console.log(AgeMax);
}

