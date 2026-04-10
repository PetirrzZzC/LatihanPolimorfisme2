BankTf bankTf = new BankTf();
Ewallet ewallet = new Ewallet();
KartuKredit kartuKredit = new KartuKredit();

Console.WriteLine("----Simulasi Checkout----");
Console.WriteLine("Pilih metode:");
Console.WriteLine("1. Bank Transfer");
Console.WriteLine("2. E-Wallet");
Console.WriteLine("3. Kartu Kredit");
Console.Write("Pilihan Anda (1/2/3): ");
    string pilihan = Console.ReadLine();

switch (pilihan)
{
    case "1":
        bankTf.Bayar(100000);
        break;
    case "2":
        ewallet.Bayar(100000);
        break;
    case "3":
        kartuKredit.Bayar(100000);
        break;
    default:
        Console.WriteLine("Pilihan Invalid!!");
        break;
}


class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine("Segera lakukan Pembayaran!");
    }
}

class BankTf : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan Transfer sejumlah Rp. {jumlah} ke Nomor rekening 1122334455 !");
    }
}

class Ewallet: MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Saldo terpotong sejumlah Rp. {jumlah}");
    }
}

class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sejumlah Rp. {jumlah} berhasil dilakukan!");
    }
}

class Pilihan
{
    static void Main(string[] pilihan)
    {
        
    }
}
