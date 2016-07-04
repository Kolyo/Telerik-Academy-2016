using System;

namespace GSM
{
    public class GSMTest
    {

        private static GSM[] GSMCollection =
            {
                new GSM("iPhone 7SGiga", "Apple", 699.99m, "Spas", new Battery("Chinese", 148.5f, 7.8f, BatteryType.LiPol), new Display("1920x1080", "16M")),
                new GSM("Galaxy S7", "Samsung", 599.99m, "Ivan", new Battery("Chinese", 248.5f, 17.8f, BatteryType.LiIon), new Display("1920x1080", "16M")),
                new GSM("Vibe Shor z90", "Lenovo", 199.99m, "Joro", new Battery("Chinese", 208.5f, 13.8f, BatteryType.LiPol), new Display("1920x1080", "16M"))
            };

        public static void ShowGSMInfo()
        {
            foreach (var item in GSMCollection)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(GSM.IPhone6S.ToString());
        }
    }
}
