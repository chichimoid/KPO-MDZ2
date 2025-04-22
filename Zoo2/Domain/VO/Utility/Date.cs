namespace Zoo2.Domain.VO.Utility;

public struct Date
{
    public ushort Year { get; }
    public byte Month { get; }
    public byte Day { get; }

    public Date(ushort year, byte month, byte day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public Date(DateTime dateTime)
    {
        Year = (ushort)dateTime.Year;
        Month = (byte)dateTime.Month;
        Day = (byte)dateTime.Day;
    }

    public override string ToString()
    {
        return $"{Year:D4}.{Month:D2}.{Day:D2}";
    }
    
    public bool EqualsDateTime(DateTime dateTime)
    {
        return dateTime.Year == Year && dateTime.Month == Month && dateTime.Day == Day;
    }
}