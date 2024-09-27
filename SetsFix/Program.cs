internal class Program

// quick exercise just for testing using sets
{
    private static void Main(string[] args)
    {
        HashSet<int> setA = new HashSet<int>();
        HashSet<int> setB = new HashSet<int>();
        HashSet<int> setC = new HashSet<int>();

        Console.Write("How many students for course A? ");
        int n = int.Parse(Console.ReadLine());        

        for (int i = 1; i <= n; i++)
        {
            int info = int.Parse(Console.ReadLine());
            setA.Add(info);
        }

        Console.Write("How many students for course B? ");
        int n2 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n2 ; i++)
        {
            int info = int.Parse(Console.ReadLine());
            setB.Add(info);
        }

        Console.Write("How many students for course C? ");
        int n3 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n3; i++)
        {
            int info = int.Parse(Console.ReadLine());
            setC.Add(info);
        }
        
        setA.UnionWith(setB);
        setA.UnionWith(setC);
        Console.WriteLine("Total students: " + setA.Count);
    }
}