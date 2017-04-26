using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.EntityAnalyzer.Entities.Parsing
{
    public class FileSource : IFileSource
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}