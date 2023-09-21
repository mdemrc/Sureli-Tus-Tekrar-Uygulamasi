using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    [DllImport("user32.dll")]
    public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

    const byte KEYEVENTF_EXTENDEDKEY = 0x0001;
    const byte KEYEVENTF_KEYUP = 0x0002;

    static void Main()
    {
        Console.WriteLine("Saniye aralığını girin:");
        int saniyeAraligi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tekrar edecek tuşu girin:");
        ConsoleKeyInfo tus = Console.ReadKey();

        Console.WriteLine("\nDurdurmak için 'dur' yazın veya konsolu kapatın.");

        bool devamEdiyor = true;

        var tusBasmaThread = new Thread(() =>
        {
            while (devamEdiyor)
            {
                Console.WriteLine($"'{tus.KeyChar}' tuşuna basılıyor...");
                BasTusu((byte)tus.Key);
                Thread.Sleep(saniyeAraligi * 1000);
            }
        });

        tusBasmaThread.Start();

        while (devamEdiyor)
        {
            string komut = Console.ReadLine().ToLower();
            if (komut == "dur")
            {
                devamEdiyor = false;
            }
        }

        tusBasmaThread.Join();
        Console.WriteLine("Uygulama kapatılıyor...");
    }

    static void BasTusu(byte tusKodu)
    {
        keybd_event(tusKodu, 0, KEYEVENTF_EXTENDEDKEY, 0);
        keybd_event(tusKodu, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
    }
}
