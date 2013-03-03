using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BatteryType
{
    LiIon, NiMH, NiCd
}

public class Battery
{
    // Fields
    private BatteryType batteryModel;
    private int? batteryHoursIdle;
    private int? batteryHoursTalk;

    // Constructors
    public Battery(BatteryType batteryModel, int? batteryHoursIdle, int? batteryHoursTalk)
    {
        this.Model = batteryModel;
        this.HoursIdle = batteryHoursIdle;
        this.HoursTalk = batteryHoursTalk;
    }

    public Battery(BatteryType batteryModel, int? batteryHoursIdle)
        : this(batteryModel, batteryHoursIdle, null)
    {
    }

    public Battery(BatteryType batteryModel)
        : this(batteryModel, null, null)
    {
    }

    // Properties
    public BatteryType Model
    {
        get { return this.batteryModel; }
        set
        {
            if (value >= 0)
            {
                this.batteryModel = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? HoursIdle
    {
        get { return this.batteryHoursIdle; }
        set {
            if (value >= 0 || value == null)
            {
                this.batteryHoursIdle = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? HoursTalk
    {
        get { return this.batteryHoursTalk; }
        set {
            if (value >= 0 || value == null)
            {
                this.batteryHoursTalk = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}