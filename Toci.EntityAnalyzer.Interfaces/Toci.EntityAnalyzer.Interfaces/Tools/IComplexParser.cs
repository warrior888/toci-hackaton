using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IComplexParser
    {
        IComplexEntity ParseEntireCt(string tableCreates);
    }
}