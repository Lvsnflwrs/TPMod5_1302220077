using System;

public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric sapa = new HaloGeneric();
        string namaPanggilan = "Praktikan";
        sapa.SapaUser(namaPanggilan);

        string nim = "1302220077";
    }
}