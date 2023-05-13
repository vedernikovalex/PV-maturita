public class PV_6
{
    public static void Main(string[] args)
    {
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(1);

        ints.Add(1);

        ints.Add(2);
        ints.Add(54);



        foreach (var intik in ints)
        {
            foreach (var inticek in ints)
            {
                Console.WriteLine(inticek);
            }
        }
    }
}