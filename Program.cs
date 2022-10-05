using System;
using System.Linq;
using System.Collections.Generic;

public class listMobil
{
    public int IDRegistrasi { get; set; }
    public string? Tipe { get; set; }
    public string? Merk { get; set; }
    public string? Varian { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Soal1();
        Soal2();
    }

    static void Soal1()
    {
        Console.WriteLine("SOAL 1");
        
        IEnumerable<listMobil> ListMobil = new listMobil[]
        {
            new listMobil
            {
                IDRegistrasi = 0001,
                Tipe = "Sedan",
                Merk = "Toyota",
                Varian = "FT86"
            },
            new listMobil
            {
                IDRegistrasi = 0002,
                Tipe = "SUV",
                Merk = "Toyota",
                Varian = "RAV4"
            },
            new listMobil
            {
                IDRegistrasi = 0003,
                Tipe = "Sedan",
                Merk = "Honda",
                Varian = "Accord"
            },
            new listMobil
            {
                IDRegistrasi = 0004,
                Tipe = "SUV",
                Merk = "Honda",
                Varian = "CRV"
            },
            new listMobil
            {
                IDRegistrasi = 0005,
                Tipe = "Sedan",
                Merk = "Honda",
                Varian = "City"
            },
        };

        // Isi code dibawah

#pragma warning disable CS8602 // Possible null reference argument.

        // no 1
        var q1 = ListMobil.Where(x => x.Merk == "Honda")
                .OrderBy(q1 => q1.IDRegistrasi)
                .Take(1)
                .ToList();

        Console.WriteLine("\nQuestion 1:");
        foreach (var s in q1)
        {
            Console.WriteLine("\nIDRegistrasi: {0}", s.IDRegistrasi);
            Console.WriteLine("Merk: {0}", s.Merk);
            Console.WriteLine("Varian: {0}", s.Varian);
        }

        // no 2
        var q2 = ListMobil.Where(x => (x.Merk == "Honda") && (x.Tipe == "Sedan"))
                .OrderBy(q2 => q2.IDRegistrasi)
                .TakeLast(1);
        Console.WriteLine("\nQuestion 2:");
        foreach (var s in q2)
        {
            Console.WriteLine("\nIDRegistrasi: {0}", s.IDRegistrasi);
            Console.WriteLine("Merk: {0}", s.Merk);
            Console.WriteLine("Varian: {0}", s.Varian);
        }

        // no 3
        var q3 = ListMobil.Where(x => (x.Merk == "Honda") && (x.Varian == "City"))
                .OrderBy(q3 => q3.IDRegistrasi)
                .First();
        Console.WriteLine("\nQuestion 3:");
        Console.WriteLine("\nIDRegistrasi: {0}", q3.IDRegistrasi);
        Console.WriteLine("Merk: {0}", q3.Merk);
        Console.WriteLine("Varian: {0}", q3.Varian);

        // no 4
        var q4 = ListMobil.Where(x => x.Merk == "Toyota").FirstOrDefault();
        Console.WriteLine("\nQuestion 4:");
        Console.WriteLine("\nIDRegistrasi: {0}", q4.IDRegistrasi);
        Console.WriteLine("Merk: {0}", q4.Merk);
        Console.WriteLine("Varian: {0}", q4.Varian);

        // no 5
        var q5 = ListMobil.Where(x => x.Tipe == "Sedan")
            .OrderBy(q5 => q5.IDRegistrasi);
        Console.WriteLine("\nQuestion 5:");
        foreach (var s in q5)
        {
            Console.WriteLine("\nIDRegistrasi: {0}", s.IDRegistrasi);
            Console.WriteLine("Merk: {0}", s.Merk);
            Console.WriteLine("Varian: {0}", s.Varian);
        }
    }

    static void Soal2()
    {
        Console.WriteLine("\nSOAL 2");
        int turn = 1;
        for (int i = 1; i <= 500; i++)
        {
            switch (turn)
            {
                // A giliran pertama, B giliran kedua, C giliran ketiga
                case 1:
                    Game(i, turn, "A");
                    break;
                case 2:
                    Game(i, turn, "B");
                    break;
                case 3:
                    Game(i, turn, "C");
                    break;
                default:
                    break;
            }

            turn++;

            if (turn > 3)
            {
                turn = 1;
            }
        }
    }

    static void Game(int i, int turn, string who)
    {
        string yell = "";
        
        if (i % 3 == 0)
        {
            yell = "Tik";
        }
        else if (i % 5 == 0)
        {
            yell = "Tek";
        }
        else if (i % 7 == 0)
        {
            yell = "Tok";
        }

        if (yell == "")
        {
            Console.WriteLine("number: {0}", i);
        }
        else
        {
            Console.WriteLine("number: {0}, turn: {1}, person: {2}, yell: {3}", i, turn, who, yell);
        }
    }

}

