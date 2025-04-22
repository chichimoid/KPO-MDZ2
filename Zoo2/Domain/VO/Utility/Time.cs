namespace Zoo2.Domain.VO.Utility;

public class Time
{
    public byte Hour { get; }
    public byte Minute { get; }

    public Time(byte hour, byte minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public Time(DateTime dateTime)
    {
        Hour = (byte)dateTime.Hour;
        Minute = (byte)dateTime.Minute;
    }

    public override string ToString()
    {
        return $"{Hour:D2}:{Minute:D2}";
    }
    
    public bool EqualsDateTime(DateTime dateTime)
    {
        return dateTime.Hour == Hour && dateTime.Minute == Minute;
    }
}