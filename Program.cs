using System;

public class Vector
{

    int max = 0;
    public class Peroana
    {
        string FirstName, LastName;
        Console.Write("Input a FirstName: ");
            FirstName = Console.ReadLine();
        Console.Write("Input a LastName: ");
            LastName = Console.ReadLine();
        DateTime YearOfBirth;
        YearOfBirth = Console.ReadLine();
        int Age;
        Age = DateTime.Now.Year - YearOfBirth;
        if (Age > max) max = Age;
    }

}

