//1.Write program to demonstrate the working of c# SDK
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}





//2. Write program to show the use of various data types availabe in c#
source code
using System;
class Program
{
    static void Main()
    {
        int age = 25; 
        float weight = 70.5f; 
        double height = 5.9; 
        decimal price = 199.99m; 
        bool isActive = true;
        char grade = 'A'; 

        string name = "Vishal"; 
        object obj = "Hello"; 

        Console.WriteLine("Integer : " + age);
        Console.WriteLine("Float : " + weight);
        Console.WriteLine("Double : " + height);
        Console.WriteLine("Decimal : " + price);
        Console.WriteLine("Boolean : " + isActive);
        Console.WriteLine("Character : " + grade);
        Console.WriteLine("String : " + name);
        Console.WriteLine("Object: " + obj);
    }
}









//3. Write a program to understand the use of  control. statement c#
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        Console.WriteLine("\nEnter a day number (1 to 7):");
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }

        Console.WriteLine("\nFor Loop Example:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }

        Console.WriteLine("\nWhile Loop Example:");
        int count = 1;
        while (count <= 3)
        {
            Console.WriteLine("Count is: " + count);
            count++;
        }

        Console.WriteLine("\nDo-While Loop Example:");
        int num = 1;
        do
        {
            Console.WriteLine("Num is: " + num);
            num++;
        } while (num <= 2);
    }
}




//4. Write a program to understand the use of library function
using System;

class Program
{
    static void Main()
    {
        double number1 = 9;
        double number2 = 16;
        double sqrt1 = Math.Sqrt(number1);  
        double sqrt2 = Math.Sqrt(number2);  
        double powerResult = Math.Pow(number1, 2); 
        Console.WriteLine($"Square root of {number1} is: {sqrt1}");
        Console.WriteLine($"Square root of {number2} is: {sqrt2}");
        Console.WriteLine($"{number1} raised to the power of 2 is: {powerResult}");

        DateTime currentDateTime = DateTime.Now;  
        DateTime specificDate = new DateTime(2025, 12, 25);  
        TimeSpan difference = specificDate - currentDateTime; 

        Console.WriteLine("\nCurrent Date and Time: " + currentDateTime);
        Console.WriteLine("Specific Date (2025-12-25): " + specificDate);
        Console.WriteLine("Difference between the specific date and now: " + difference.Days + " days");


        string text = "Hello, C# World!";
        string upperText = text.ToUpper();  
        string lowerText = text.ToLower();  
        bool containsWord = text.Contains("C#");  
        Console.WriteLine("\nOriginal Text: " + text);
        Console.WriteLine("Text in Uppercase: " + upperText);
        Console.WriteLine("Text in Lowercase: " + lowerText);
        Console.WriteLine("Does the text contain 'C#'? " + containsWord);

        
        string numberStr = "1234";
        int convertedNumber = Convert.ToInt32(numberStr);  

        Console.WriteLine("\nConverted string '1234' to integer: " + convertedNumber);

        // Random Library Function
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);  // Generates a random number between 1 and 100

        Console.WriteLine("\nRandom number between 1 and 100: " + randomNumber);
    }
}






//5. Write a program to demonstrate the use of various arithmetic, unary, logical, bit-wise, assignment and conditional operators.

using System;
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a - b = {a - b}");
        Console.WriteLine($"a * b = {a * b}");
        Console.WriteLine($"a / b = {a / b}");
        Console.WriteLine($"a % b = {a % b}");

        Console.WriteLine("\nUnary Operators:");
        int x = 10;
        Console.WriteLine($"++x = {++x}");  
        Console.WriteLine($"x++ = {x++}");  
        Console.WriteLine($"--x = {--x}");  
        Console.WriteLine($"x-- = {x--}");  
        Console.WriteLine($"!true = {!true}"); 

     
        bool p = true, q = false;
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine($"p && q = {p && q}");
        Console.WriteLine($"p || q = {p || q}");
        Console.WriteLine($"!p = {!p}");

     
        Console.WriteLine("\nBitwise Operators:");
        int i = 5, j = 3;  
        Console.WriteLine($"i & j = {i & j}");  
        Console.WriteLine($"i | j = {i | j}"); 
        Console.WriteLine($"i ^ j = {i ^ j}");  
        Console.WriteLine($"~i = {~i}");        
        Console.WriteLine($"i << 1 = {i << 1}");  
        Console.WriteLine($"i >> 1 = {i >> 1}");  

       
        int result = 0;
        Console.WriteLine("\nAssignment Operators:");
        result = a + b;
        Console.WriteLine($"result = a + b = {result}");
        result += 10;
        Console.WriteLine($"result += 10 = {result}");
        result -= 5;
        Console.WriteLine($"result -= 5 = {result}");
        result *= 2;
        Console.WriteLine($"result *= 2 = {result}");
        result /= 3;
        Console.WriteLine($"result /= 3 = {result}");
        result %= 4;
        Console.WriteLine($"result %= 4 = {result}");

      
        Console.WriteLine("\nConditional Operator:");
        int max = (a > b) ? a : b;
        Console.WriteLine($"The maximum of a and b is {max}");
        string str = null;
        string resultStr = str ?? "Default value";
        Console.WriteLine($"\nNull-coalescing Operator: {resultStr}");

        Console.WriteLine("\nCompound Assignment Operator:");
        int z = 20;
        z *= 2;
        Console.WriteLine($"z *= 2 results in z = {z}");
        Console.WriteLine("\nEnd of Demonstration!");
    }
}





//6. Write a program to store 10 elements in an array and display the array elements in increasing order.

using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.WriteLine("\nArray elements in increasing order:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine(); 
    }
}







