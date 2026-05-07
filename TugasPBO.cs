using System;
using System.Collections.Generic;

class Produk
{
    public string Nama { get; set; }
    public double Harga { get; set; }

    public Produk(string nama, double harga)
    {
        Nama = nama;
        Harga = harga;
    }

    public virtual string Kategori()
    {
        return "Produk";
    }
}

class Elektronik : Produk
{
    public int Garansi { get; set; }

    public Elektronik(string nama, double harga, int garansi)
        : base(nama, harga)
    {
        Garansi = garansi;
    }

    public void CekGaransi()
    {
        Console.WriteLine($"Garansi: {Garansi} Bulan");
    }

    public override string Kategori()
    {
        return "Elektronik";
    }
}

class Makanan : Produk
{
    public DateTime TanggalKadaluarsa { get; set; }

    public Makanan(string nama, double harga, DateTime tanggalKadaluarsa)
        : base(nama, harga)
    {
        TanggalKadaluarsa = tanggalKadaluarsa;
    }

    public void CekKadaluarsa()
    {
        Console.WriteLine($"Kadaluarsa: {TanggalKadaluarsa:dd/MM/yyyy}");
    }

    public override string Kategori()
    {
        return "Makanan";
    }
}

class Laptop : Elektronik
{
    public Laptop(string nama, double harga, int garansi)
        : base(nama, harga, garansi)
    {
    }

    public void InstallSoftware()
    {
        Console.WriteLine("Menginstal software...");
    }

    public override string Kategori()
    {
        return "Laptop";
    }
}

class HP : Elektronik
{
    public HP(string nama, double harga, int garansi)
        : base(nama, harga, garansi)
    {
    }

    public void Telepon()
    {
        Console.WriteLine("Melakukan panggilan...");
    }

    public override string Kategori()
    {
        return "Handphone";
    }
}

class Snack : Makanan
{
    public Snack(string nama, double harga, DateTime tanggalKadaluarsa)
        : base(nama, harga, tanggalKadaluarsa)
    {
    }

    public void Makan()
    {
        Console.WriteLine("Snack dimakan...");
    }

    public override string Kategori()
    {
        return "Snack";
    }
}

class Minuman : Makanan
{
    public Minuman(string nama, double harga, DateTime tanggalKadaluarsa)
        : base(nama, harga, tanggalKadaluarsa)
    {
    }

    public void Dinginkan()
    {
        Console.WriteLine("Minuman didinginkan...");
    }

    public override string Kategori()
    {
        return "Minuman";
    }
}

class Program
{
    static void Garis()
    {
        Console.WriteLine(new string('=', 60));
    }

    static void Judul(string text)
    {
        Garis();
        Console.WriteLine($"| {text.PadRight(56)} |");
        Garis();
    }

    static void Isi(string text)
    {
        Console.WriteLine($"| {text.PadRight(56)} |");
    }

    static void Main(string[] args)
    {
        // Objek Produk
        Laptop laptop = new Laptop("Asus ROG", 15000000, 24);
        HP hp = new HP("Samsung S24", 12000000, 12);
        Snack snack = new Snack("Chitato", 15000, new DateTime(2026, 12, 31));
        Minuman minuman = new Minuman("Coca Cola", 10000, new DateTime(2026, 10, 20));

        // =========================
        // TABEL LAPTOP
        // =========================
        Judul("TABEL LAPTOP");

        Isi($"Nama        : {laptop.Nama}");
        Isi($"Harga       : Rp{laptop.Harga}");
        Isi($"Kategori    : {laptop.Kategori()}");
        Isi($"Garansi     : {laptop.Garansi} Bulan");

        Garis();

        // =========================
        // TABEL HP
        // =========================
        Judul("TABEL HP");

        Isi($"Nama        : {hp.Nama}");
        Isi($"Harga       : Rp{hp.Harga}");
        Isi($"Kategori    : {hp.Kategori()}");
        Isi($"Garansi     : {hp.Garansi} Bulan");

        Garis();

        // =========================
        // TABEL SNACK
        // =========================
        Judul("TABEL SNACK");

        Isi($"Nama        : {snack.Nama}");
        Isi($"Harga       : Rp{snack.Harga}");
        Isi($"Kategori    : {snack.Kategori()}");
        Isi($"Kadaluarsa  : {snack.TanggalKadaluarsa:dd/MM/yyyy}");

        Garis();

        // =========================
        // TABEL MINUMAN
        // =========================
        Judul("TABEL MINUMAN");

        Isi($"Nama        : {minuman.Nama}");
        Isi($"Harga       : Rp{minuman.Harga}");
        Isi($"Kategori    : {minuman.Kategori()}");
        Isi($"Kadaluarsa  : {minuman.TanggalKadaluarsa:dd/MM/yyyy}");

        Garis();

        // =========================
        // POLYMORPHISM
        // =========================
        Judul("POLYMORPHISM");

        Produk p1 = laptop;
        Produk p2 = snack;

        Isi($"Objek 1 = {p1.Kategori()}");
        Isi($"Objek 2 = {p2.Kategori()}");

        Garis();

        // =========================
        // METHOD KHUSUS
        // =========================
        Judul("METHOD KHUSUS");

        Isi("Laptop  -> Menginstal software...");
        Isi("HP       -> Melakukan panggilan...");
        Isi("Snack    -> Snack dimakan...");
        Isi("Minuman  -> Minuman didinginkan...");

        Garis();

        // Method asli dipanggil
        laptop.InstallSoftware();
        hp.Telepon();
        snack.Makan();
        minuman.Dinginkan();
    }
}