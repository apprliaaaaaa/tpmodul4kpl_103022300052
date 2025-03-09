using tpmodul4_103022300052;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + KodePos.GetKodePos("Kujangsari"));

        Console.WriteLine("===== SIMULASI DOOR MACHINE =====\n");

        DoorMachine pintu = new DoorMachine();

        Console.WriteLine(">>> Membuka pintu...");
        pintu.BukaPintu(); 

        Console.WriteLine(">>> Mengunci pintu...");
        pintu.KunciPintu(); 

        Console.WriteLine(">>> Membuka pintu lagi...");
        pintu.BukaPintu(); 

        Console.WriteLine(">>> Mencoba membuka pintu yang sudah terbuka...");
        pintu.BukaPintu(); 

        Console.WriteLine(">>> Mengunci pintu...");
        pintu.KunciPintu(); 
        Console.WriteLine(">>> Mencoba mengunci pintu yang sudah terkunci...");
        pintu.KunciPintu(); 

        Console.WriteLine("\n===== SIMULASI SELESAI =====");
        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}

