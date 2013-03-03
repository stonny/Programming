using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GSMTest
{
    static void Main()
    {
        GSM[] testPhone = new GSM[3];
        // First Test Phone
        Display testDisplay = new Display(4.1, 16000000);
        Battery testBattery = new Battery(BatteryType.LiIon, 12, 6);

        GSM firstGSM = new GSM("Xperia Arc", "Sony", 450, "Georgi", testBattery, testDisplay);
        testPhone[0] = firstGSM;
        // Second Test Phone
        testDisplay = new Display(4.5, 256000000);
        testBattery = new Battery(BatteryType.NiCd, 9, 7);

        GSM secondGSM = new GSM("Optimus", "LG", 650, "Pesho", testBattery, testDisplay);
        testPhone[1] = secondGSM;
        // Third Test Phone
        testDisplay = new Display(5.0, 256000000);
        testBattery = new Battery(BatteryType.NiMH, 11, 8);

        GSM thirdGSM = new GSM("One", "HTC", 950, "Ivan", testBattery, testDisplay);
        testPhone[2] = thirdGSM;

        // Printing Test Phones
        for (int i = 0; i < testPhone.Length; i++)
        {
            Console.WriteLine(testPhone[i]);
            Console.WriteLine(new string('*', 35));
        }

        // Printing Iphone Information
        Console.WriteLine(GSM.Iphone);
    }
}