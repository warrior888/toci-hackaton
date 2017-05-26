using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Tools;

namespace Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser
{
    public class PostCodeEntity : IPostCodeEntity
    {
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string Place { get; set; }
        public string Province { get; set; }
        public string County { get; set; }

        private string RemoveThis<TParseResult, TNumber>(int whatever, string doSth)
        {
            TParseResult inst1;
            TNumber inst2;
            return "erley".Replace(doSth, "I like it");
        }

        public void ShowThis<TWhatever, TErley>()
        {
            TWhatever instance;
        }

        public void RemoveThis()
        {
            
        }
    }
}