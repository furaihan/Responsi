using System;

namespace ResponsiPemrograman4374
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("1903024455", 2500000, "Virgil Van Dijk");
            Karyawan karyawan2 = new Karyawan("1903024798", 3500000, "Sergio Ramos");
            Console.WriteLine("No  NIK/Nama \t\t\t\t Gaji Bulanan");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"1.  {karyawan1.NIK} {karyawan1.Nama} \t\t {karyawan1.GajiBulanan}");
            Console.WriteLine($"1.  {karyawan2.NIK} {karyawan2.Nama} \t\t {karyawan2.GajiBulanan}");
            Console.WriteLine();
            Console.WriteLine("Kenaikan gaji 10%");
            karyawan1.AddSalaryPercentage(10);
            karyawan2.AddSalaryPercentage(10);
            Console.WriteLine("No  NIK/Nama \t\t\t\t Gaji Bulanan");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"1.  {karyawan1.NIK} {karyawan1.Nama} \t\t {karyawan1.GajiBulanan}");
            Console.WriteLine($"1.  {karyawan2.NIK} {karyawan2.Nama} \t\t {karyawan2.GajiBulanan}");
            Console.ReadLine();
        }
    }
}