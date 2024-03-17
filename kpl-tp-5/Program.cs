internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Praktikan");
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T sapa)
    {
        Console.WriteLine("Halo User " + sapa);
    }
}