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

    public static int superDigit(string n, int k)
    {
        string p = string.Empty;
        int sum = 0;
        int firstOperationCount = 0;

        if (firstOperationCount < 1)
        {
            for (int i = 1; i <= k; i++)
            {
                p += n;
                firstOperationCount++;
            }
        }
        int parsedValue = int.Parse(p);

        for (int i = parsedValue; i > 0; i--)
        {
            if (parsedValue < 10)
            {
                sum = i;
                Console.WriteLine($"Super Digit is {parsedValue}");
                return parsedValue;
            }
            else
            {
                foreach (var charItem in p)
                {
                    sum += int.Parse(charItem.ToString());
                }
                parsedValue = sum;
                p = parsedValue.ToString();
                sum = 0;
            }
        }
        Console.ReadKey();
        return parsedValue;
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
