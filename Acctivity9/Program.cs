using System;

public class Methods
{
    //1. takes two integers and *displays* their sum
    public static void Sum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    //2. takes 5 doubles and *returns* their average
    public static double Avg(double num1, double num2, double num3, double num4, double num5)
    {
        double average;
        average = (num1 + num2 + num3 + num4 + num5) / 5;
        return average;
    }

    //3. *returns* the sum of 2 random integers.
    public static int randomSum()
    {
        int num1, num2;
        Random random = new Random();
        num1 = random.Next();
        num2 = random.Next();
        return num1 + num2;
    }

    //4. takes 3 integers and *returns* true if their sum is divisible by 3, otherwise false
    public static bool canDivideBy3(int num1, int num2, int num3)
    {
        int sum;
        sum = num1 + num2 + num3;

        if (sum % 3 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //5. take 2 strings and *displays* the string with fewest characters. 
    public static void shortestString(string str1, string str2)
    {
        if (str1.Length < str2.Length)
        {
            Console.WriteLine(str1);
        }
        else
        {
            Console.WriteLine(str2);
        }
    }

    //6. takes an array of doubles and *returns* the largest value in array
    public static double largestValueArray(double[] array)
    {
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    //7. generates and *returns* an array of 50 integer values
    public static int[] fiftyVal()
    {
        int[] array = new int[50];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }
        return array;
    }

    //8. takes 2 bool variables and *returns* true if they have the same value, false otherwise
    public static bool areSameVal(bool bool1, bool bool2)
    {
        if (bool1 == true && bool2 == true)
        {
            return true;
        }
        else if (bool1 == false && bool2 == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //9. takes an int and a double and *returns* their product
    public static double findProduct(int num1, double num2)
    {
        return num1 * num2;
    }

    //10. takes a two-dimensional array of integers and *returns* the average of the entries
    public static int arrayAvg(int[,] array)
    {
        int count = 0;
        int sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i,j];
                count++;
            }
        }
        return sum / count; 
    }

    public static void Main()
    {
        //test 1
        Sum(5, 19);

        //test 2
        Console.WriteLine(Avg(4, 7, 9, 3, 8));

        //test 3
        Console.WriteLine(randomSum());

        //test 4
        Console.WriteLine(canDivideBy3(3, 6, 12));

        //test 5
        shortestString("love", "coding");

        // test 6
        double[] arr = { 1234, 13, 4242, 134, 123 };
        Console.WriteLine(largestValueArray(arr));

        // test 7
        int[] newArray = fiftyVal();
        foreach (int item in newArray)
        {
            Console.Write(item + " ");
        }

        //test 8
        Console.WriteLine(areSameVal(false, false));

        //test 9
        Console.WriteLine(findProduct(3, 13));

        //test10
        int[,] array2d = { { 1, 2, 3 }, { 4, 5, 6 } }; 
        Console.WriteLine(arrayAvg(array2d));
    }
}