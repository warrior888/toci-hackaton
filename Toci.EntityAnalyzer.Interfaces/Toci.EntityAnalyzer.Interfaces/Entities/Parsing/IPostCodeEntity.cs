namespace Toci.EntityAnalyzer.Interfaces.Entities.Parsing
{
    public interface IPostCodeEntity : IParseResult
    {
        string PostCode { get; set; }
        string Address { get; set; }
        string Place { get; set; }
        string Province { get; set; }
        string County { get; set; }

    }
}