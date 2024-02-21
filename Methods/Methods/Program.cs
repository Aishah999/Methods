namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine(Print(12, 3));
        //int[] numbers = { 12, 23, 43, 56 };
        //Console.WriteLine(Sum(numbers));
        //Console.WriteLine(showNumber(34,43));
    }
    static int Print(int a,int b)
    {
        return a / b;
    }
    static int Sum(int[] arry)
    {
        int sum = 0;
        for (int i = 0; i < arry.Length; i++)
        {
            sum += arry[i];
        }
        return sum;
    }
    static int showNumber (int n, int m)
    {
        int count = 0;
        for (int i = n; i < m; i++)
        {
            if(i%2==1)
            {
                count++;
                
            }
          
           
        }
        return count;
        
        
    }
    

}
