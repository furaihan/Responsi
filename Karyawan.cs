using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4374
{
    internal class Karyawan
    {
        public Karyawan(string nik, int gaji, string nama)
        {
            this.NIK = nik;
            this.GajiBulanan = gaji > 0 ? gaji : 0;
            this.Nama = nama;
        }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }
        public string Nama { get; set; }
        public void AddSalaryPercentage(int percentage)
        {
            if (percentage > 0)
            {
                GajiBulanan += GajiBulanan * percentage / 100;
            }
        }
    }
}
