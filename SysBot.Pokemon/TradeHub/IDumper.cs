namespace SysBot.Pokemon
{
    public interface IDumper
    {
        bool Dump { get; set; }
        string DumpFolder { get; set; }
        public string DumpUrl { get; set; }
    }
}