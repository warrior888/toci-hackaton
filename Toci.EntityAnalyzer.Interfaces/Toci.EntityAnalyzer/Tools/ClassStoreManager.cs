using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public abstract class ClassStoreManager : IClassStoreManager
    {
        public abstract void Save(string classCode);
    }
}