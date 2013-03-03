using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSMCallHistoryTest
{
    static void Main()
    {
        // Instance of the GSM Class
        Display testDisplay = new Display(4.1, 16000000);
        Battery testBattery = new Battery(BatteryType.LiIon, 12, 6);
        GSM testGSM = new GSM("Xperia Arc", "Sony", 450, "Georgi", testBattery, testDisplay);
        // Add Calls
        testGSM.AddCall(DateTime.Now, "0883598765", 150.4);
        testGSM.AddCall(DateTime.Now.AddDays(1), "0885684258", 258.6);

        // Print Call History
        Console.WriteLine("Call History:");
        testGSM.PrintCallHistory();


        // Calculate The Total Price
        Console.WriteLine("Total Price: {0:F2}$", testGSM.CalculatePrice(0.37));

        // Removing The Longest Call from the history and calculating the Price again
        testGSM.RemoveCall("0885684258");
        Console.WriteLine("Total Price After Removing Longest Call Duration: {0:F2}$", testGSM.CalculatePrice(0.37));

        //Clearing The Call History
        testGSM.ClearHistory();
        testGSM.PrintCallHistory();
    }
}