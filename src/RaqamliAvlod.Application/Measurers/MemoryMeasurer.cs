namespace RaqamliAvlod.Application.Measurers
{
    public class MemoryMeasurer
    {
        public static uint GetMemory(uint[] memories)
            => memories.Max();
    }
}
