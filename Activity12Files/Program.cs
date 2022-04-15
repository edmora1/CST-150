using System;

public class LetterCount
{
    public static void Main()
    {
        int ltrCount = 0;
        int i = 1; 

       string inputFile = System.IO.File.ReadAllText("Input.txt");
       
        char[] chars = inputFile.ToCharArray();

       
        while(i < chars.Length) 
       { 
            if ((chars[i] == '.' || chars[i] == ' ' || chars[i] == ',' || chars[i] == '!' || chars[i] == '\n') && (chars[i-1] == 't' || chars[i -1] == 'e'))
            {
                ltrCount++;
            }
            i++;
       }
        Console.WriteLine("There are " + ltrCount + " words ending in t or e"); 
    }
}
  