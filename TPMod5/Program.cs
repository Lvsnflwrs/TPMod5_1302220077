using System;


public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }

    public class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
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
            DataGeneric<string> data = new DataGeneric<string>(nim);
            data.PrintData();
        }
    }
}
