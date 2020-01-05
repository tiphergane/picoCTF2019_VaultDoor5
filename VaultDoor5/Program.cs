using System;
using System.Text;


namespace VaultDoor5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Encoded = "JTYzJTMwJTZlJTc2JTMzJTcyJTc0JTMxJTZlJTY3JTVm"
                           + "JTY2JTcyJTMwJTZkJTVmJTYyJTYxJTM1JTY1JTVmJTM2"
                           + "JTM0JTVmJTMwJTY2JTMzJTMwJTM5JTY0JTM0JTMw";
            byte[] Data = Convert.FromBase64String(Encoded);
            string Decoded = Encoding.UTF8.GetString(Data);
            string Flag = Uri.UnescapeDataString(Decoded);

            string s = "picoCTF{";
            string e = "}";
            Console.WriteLine("Code a déchiffrer : {0}", Encoded);
            Console.WriteLine("La clef est : {0}{1}{2}", s, Flag, e);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;


        }
    }
}
