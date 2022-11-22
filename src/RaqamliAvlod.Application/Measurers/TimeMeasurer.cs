namespace RaqamliAvlod.Application.Measurers
{
    public class TimeMeasurer
    {
        public static ushort GetTime(ushort[] times)
            => times.Max();
    }
}
