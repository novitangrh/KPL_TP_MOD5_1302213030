
class HaloGeneric
{
    public void SapaUser(String X)
    {
        Console.WriteLine("Masukkan nama " + X);
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
        Console.WriteLine("Data yang tersimpan adalah: " + data);

    }
}


class main
{
    public static void Main(String[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        String x = Console.ReadLine();
        halo.SapaUser(x);
        DataGeneric<String> data = new DataGeneric<string>("1302213030");
        data.PrintData();

    }
}