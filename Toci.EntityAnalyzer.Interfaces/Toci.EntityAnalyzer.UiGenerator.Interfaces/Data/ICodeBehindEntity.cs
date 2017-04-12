using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Data
{
    /// <summary>
    /// Contains generated code behind
    /// </summary>
    public interface ICodeBehindEntity : ICodeEntity
    {
        //maybe in ICodeEntity
        string Name { get; set; }
        string Materialize();
    }
}