using Toci.Generator.Core.Interfaces.Entities;

namespace Toci.Generator.Core
{
    public class CodeFragment : ICodeFragment
    {
        public string Comment { get; set; }
        public string CodeLine { get; set; }
    }
}