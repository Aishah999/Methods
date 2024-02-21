namespace Method;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine(CheckNumberPrime(8));
        //Console.WriteLine(IsPower(16));
    }
    static string CheckNumberPrime(int num)
    {
        int count = default;

        for (int i = 1; i <= num; i++)
        {
            if(num%i==0)
            {
                count++;
            }
        }
        return count > 2 ? "murekkebdir" : "sadedir";
    }
    static bool IsPower(double num)
    {
        while (num>1)
        {
            num /= 2;
        }
        return num == 1 ? true : false;
    }
}

