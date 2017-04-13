using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IClassCodeManager
    {
        void GenerateClass(IClassCode classCode, IClassStoreManager classStoreManager);
    }
}