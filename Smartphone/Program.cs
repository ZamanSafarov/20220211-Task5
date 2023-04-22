using System;
using System.Numerics;
using System.Threading;
using ClassLibrary.Helpers;

namespace Smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Smartphone Store";

            int len;

        back:

            len = Monitor.ReadInteger("How many phone brands are you interested in? : ");
            if (len <=0)
            {
                goto back;
            }
            Iphones[] phones = new Iphones[len];

            for (int i = 0; i < phones.Length; i++)
            {

                Iphones phone = new Iphones();


                phone.name = Monitor.ReadString($"{i+1}.Smartphone Name: ");
                phone.producer = Monitor.ReadString($"{i+1}.Smartphone Producer: ");
                phone.type = Monitor.ReadString($"{i+1}.Smartphone Type: ");
                phone.bluetoothVersion = Monitor.ReadString($"{i+1}.Bluetooth Version: ");
                phone.color = Monitor.ReadString($"{i + 1}.Smartphone's Color: ");
                phone.OS = Monitor.ReadString($"{i + 1}.Operating System: ");
                phone.NFC = Monitor.ReadString($"{i + 1}.NFC: ");
                phone.price = Monitor.ReadInteger($"{i+1}.Smartphone Price: ");
                phone.memory = Monitor.ReadInteger($"{i+1}.Smartphone's Mmemory: ");
                phone.cores = Monitor.ReadInteger($"{i+1}.Cores: ");
                phone.year = Monitor.ReadInteger($"{i+1}.Production year: ");
                phone.weight = Monitor.ReadInteger($"{i+1}.Weight: ");
                phone.SIMcard = Monitor.ReadInteger($"{i + 1}.Number of SIM cards: ");
                phone.ImageCap = Monitor.ReadInteger($"{i + 1}.Capability of Image: ");
                phone.Screen = Monitor.ReadInteger($"{i + 1}.Screen: ");

                phones[i] = phone;
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("################ List of Smartphones ###############");

            foreach (var item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine("*********************");
            }

            Console.ReadKey();
        }
    }
}
