internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Praktikan");
        var data = new DataGeneric<String>("1302220067");
        data.PrintData();
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T sapa)
    {
        Console.WriteLine("Halo User " + sapa);
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang disimpan adalah: " + data);
    }
}