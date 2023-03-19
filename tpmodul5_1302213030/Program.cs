// See https://aka.ms/new-console-template for more information

class HaloGeneric
{
    public void SapaUser(String X)
    {
        Console.WriteLine("Masukkan nama : " + X); 
    }
}


class main
{
    public static void Main(String[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        String x = Console.ReadLine();
        halo.SapaUser(x);
    }
}
