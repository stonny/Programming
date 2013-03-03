using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GSM
{
    public Battery Battery = new Battery(BatteryType.LiIon, null, null);
    public Display Display = new Display(null, null);
    // Fields
    private string gsmModel;
    private string gsmManufacturer;
    private decimal? gsmPrice;
    private string gsmOwner;

    // Static Field

    static private GSM iPhone = new GSM("iPhone", "Apple", 895, "Kolio", new Battery(BatteryType.LiIon, 6, 8), new Display(3.3, 16000000));

    // Constructors
    public GSM(string gsmModel, string gsmManufacturer, decimal? gsmPrice, string gsmOwner, Battery battery, Display display)
    {
        this.Model = gsmModel;
        this.Manufacturer = gsmManufacturer;
        this.Price = gsmPrice;
        this.Owner = gsmOwner;
        this.Battery = battery;
        this.Display = display;
    }

    public GSM(string gsmModel, string gsmManufacturer)
        : this(gsmModel, gsmManufacturer, null, null, null, null)
    {
    }

    public GSM(string gsmModel, string gsmManufacturer, decimal gsmPrice)
        : this(gsmModel, gsmManufacturer, gsmPrice, null, null, null)
    {
    }

    public GSM(string gsmModel, string gsmManufacturer, decimal gsmPrice, string gsmOwner)
        : this(gsmModel, gsmManufacturer, gsmPrice, gsmOwner, null, null)
    {
    }

    // Properties
    public string Model
    {
        get { return this.gsmModel; }
        set 
        {
            if (value.Length >= 0)
            {
                this.gsmModel = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Manufacturer
    {
        get { return this.gsmManufacturer; }
        set
        {
            if (value.Length >= 0)
            {
                this.gsmManufacturer = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public decimal? Price
    {
        get { return this.gsmPrice; }
        set
        {
            if ((value == 0) || (value >= 0))
            {
                this.gsmPrice = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
    public string Owner
    {
        get { return this.gsmOwner; }
        set
        {
            if (value.Length >= 0)
            {
                this.gsmOwner = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    // CallHistory Property
    public List<Call> CallHistory = new List<Call>();

    // Iphone Property
    public static GSM Iphone
    {
        get
        {
            return iPhone;
        }
    }

    // Methods
    // Print Information
    public override string ToString()
    {
        StringBuilder printText = new StringBuilder();
        printText.AppendLine("GSM");
        printText.AppendLine(new string('-', 25));
        printText.Append("Model: ");
        printText.AppendLine(this.gsmModel);
        printText.Append("Manufacturer: ");
        printText.AppendLine(this.gsmManufacturer);
        printText.Append("Price: ");
        printText.AppendLine(this.gsmPrice.ToString());
        printText.Append("Owner: ");
        printText.AppendLine(this.gsmOwner);
        printText.Append("Battery Model: ");
        printText.AppendLine(this.Battery.Model.ToString());
        printText.Append("Hours Idle: ");
        printText.AppendLine(this.Battery.HoursIdle.ToString());
        printText.Append("Hours Talk: ");
        printText.AppendLine(this.Battery.HoursTalk.ToString());
        printText.Append("Display Size: ");
        printText.AppendLine(this.Display.Size.ToString());
        printText.Append("Display Colours: ");
        printText.AppendLine(this.Display.Colours.ToString());
        printText.AppendLine(new string('*', 35));
        return printText.ToString();
    }

    // Add Calls Method
    public void AddCall(DateTime date, string dialedPhoneNumber, double? callDuration)
    {
        Call NewCall = new Call(date, dialedPhoneNumber, callDuration);
        CallHistory.Add(NewCall);
    }
    
    // Remove Calls Method 
    public void RemoveCall(string dialedPhoneNumber)
    {
        for (int i = 0; i < CallHistory.Count; i++)
        {
            if (String.Equals(CallHistory[i].DialedPhoneNumber, dialedPhoneNumber))
            {
                CallHistory.RemoveAt(i);
                i--;
            }
        }
    }

    // Clear Call History Method
    public void ClearHistory()
    {
        CallHistory.Clear();
    }

    // Calculate Price for the Calls Method
    public double? CalculatePrice(double? pricePerMinute)
    {
        double? wholeTime = 0;
        for (int i = 0; i < CallHistory.Count; i++)
        {
            wholeTime += CallHistory[i].CallDuration;
        }

        double? price = pricePerMinute * (wholeTime / 60);
        return price;
    }

    // Print Call History Method
    public void PrintCallHistory()
    {
        foreach (var i in this.CallHistory)
        {
            Console.WriteLine("Date: {0}", i.Date);
            Console.WriteLine("PhoneNumber: {0}", i.DialedPhoneNumber);
            Console.WriteLine("Duration: {0}s", i.CallDuration);
            Console.WriteLine(new string('*', 25));
        }
    }

}