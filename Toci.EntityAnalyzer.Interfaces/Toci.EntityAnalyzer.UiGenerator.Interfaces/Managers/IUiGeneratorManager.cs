using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers
{
    public interface IUiGeneratorManager<in TParser, in TControlGenerator>
        where TParser : ISource
    {
        void GenerateUi(TParser parser, TControlGenerator controlGenerator);
    }
}