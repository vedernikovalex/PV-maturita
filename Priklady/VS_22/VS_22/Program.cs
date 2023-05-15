using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        await MyMethod();
    }

    public static async Task MyMethod()
    {
        Console.WriteLine("MyMethod started :)");
        Task<int> countSeconds = CountingSeconds(4);

        await Task.Delay(2000);
        Console.WriteLine("i have waited for 2 seconds");

        int resultSeconds = await countSeconds;
        Console.WriteLine(resultSeconds);
    }

    public static async Task<int> CountingSeconds(int seconds)
    {
        int result = 0;
        for (int i = 0; i < seconds; i++)
        {
            await Task.Delay(1000);
            result++;
            Console.WriteLine("Secconds currently: " + result);
        }
        return result;
    }

}
