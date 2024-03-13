class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */


    // OPTION 1 (low level approach and complicated)
    public static int superDigit(string n, int k)
    {
        string p = string.Empty;
        int pVal = 0;
        int sum = 0;
       

        for (int i = 1; i <= k; i++)
        {
            p += n;
        }
        for (int i = 0; i < p.Length; i++)
        {
            pVal += int.Parse(p[i].ToString());
        }

        for (int i = pVal; i > 0; i--)
        {
            if (pVal < 10)
            {
                sum = i;
                Console.WriteLine($"Super Digit is {pVal}");
                return pVal;
            }
            else
            {
                foreach (var charItem in p)
                {
                    sum += int.Parse(charItem.ToString());
                }
                pVal = sum;
                p = pVal.ToString();
                sum = 0;
            }
        }
        return pVal;
    }

    // OPTION 2 (Simple and Better)
    public static int SuperDigit(string baseNumber, int repetitions)
    {
        if (string.IsNullOrEmpty(baseNumber) || repetitions <= 0)
        {
            throw new ArgumentException("Invalid input");
        }
        // Concatenate the base number 'repetitions' times
        string concatenatedNumber = string.Concat(Enumerable.Repeat(baseNumber, repetitions));

        // Calculate the sum of digits more efficiently
        int sumDigits = 0;
        foreach (char digitChar in concatenatedNumber)
        {
            sumDigits += digitChar;
        }

        // Calculate super digit directly
        int superDigitValue = sumDigits % 9;
        if (superDigitValue == 0)
        {
            superDigitValue = 9;
        }

        Console.WriteLine($"Super Digit is {superDigitValue}");
        return superDigitValue;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
