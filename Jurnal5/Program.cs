using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan hasil = new Penjumlahan();
        hasil.JumlahTigaAngka(13 + 02 + 96);
        Console.ReadLine();

        simpleDataBase data = new simpleDataBase();
        data.printAllData(data);
    }
}
public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic tempa = 13;
        dynamic tempb = 02;
        dynamic tempc = 96;

        dynamic hasil = tempa + tempb + tempc;

        Console.WriteLine($"Penjumlahan Tiga Angka {hasil}");
    }

    internal void JumlahTigaAngka(object hasil)
    {
        throw new NotImplementedException();
    }
}

public class simpleDataBase
{
    private void storedData <T>()
    {
        simpleDataBase data = new simpleDataBase();
        data.storedData(data);

    }
    private void inputDates<Date>()
    {
        Date = Today(data);
        Console.WriteLine(Date);
    }
    public class AddNewData()
    {
        
    }
    public static void PrintAllData()
    {
        Console.WriteLine(data);
    }
}