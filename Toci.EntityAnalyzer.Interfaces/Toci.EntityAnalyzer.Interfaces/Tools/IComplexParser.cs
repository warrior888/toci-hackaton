using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IComplexParser // : IChorManager
    {
        IComplexEntity ParseEntireCt(string tableCreates);
    }
}