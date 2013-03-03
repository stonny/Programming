using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Call
{
    // Fields
    private DateTime date = new DateTime();
    private string dialedPhoneNumber;
    private double? callDuration;

    // Constructors
    public Call(DateTime date, string dialedPhoneNumber, double? callDuration)
    {
        this.Date = date;
        this.DialedPhoneNumber = dialedPhoneNumber;
        this.CallDuration = callDuration;
    }

    //Properties
    public DateTime Date
    {
        get { return this.date; }
        set { this.date = value; }
    }

    public string DialedPhoneNumber
    {
        get { return this.dialedPhoneNumber; }
        set { this.dialedPhoneNumber = value; }
    }

    public double? CallDuration
    {
        get { return this.callDuration; }
        set { this.callDuration = value; }
    }
}