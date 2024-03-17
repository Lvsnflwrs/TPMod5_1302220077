using System;

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
        string nim = "1302220077";

        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}
