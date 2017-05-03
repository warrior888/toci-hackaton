namespace Toci.EntityAnalyzer.Interfaces.Entities.Parsing
{
    public interface IFileSource : ISource
    {
        string FilePath { get; set; }
        string FileName { get; set; }
    }
}