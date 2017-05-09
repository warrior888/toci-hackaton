using System.Collections.Generic;
using System.Runtime.InteropServices;
using Toci.EntityAnalyzer.Entities.Parsing;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Tools.PostCodeParser;
using Toci.EntityAnalyzer.UiGenerator.Controls.PostCodeControlGenerator;
using Toci.EntityAnalyzer.UiGenerator.Custom.PostCodeUiGenerator;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Custom.PostCodeUiGenerator;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.Generator.Core.Interfaces.Managers.PostCodeManager;

namespace Toci.Generator.Core.Managers.PostCodeManager
{
    public class PostCodeManager : IPostCodeManager
    {

        private readonly PostCodeTextFileParser<TextFileSource, PostCodeEntity> _parseResult = new PostCodeTextFileParser<TextFileSource, PostCodeEntity>();
        public IEnumerable<IPostCodeEntity> postCodeEntitys { get; set; }
        

        public PostCodeManager(string filePath, string fileName)
        {
            ITextFileSource source = new TextFileSource { FilePath = filePath, FileName = fileName};
            postCodeEntitys = _parseResult.Parse((TextFileSource)source);
            
            
            IPostCodeUiGenerator<PostCodeEntity, IControlEntity, ICodeBehindGenerator> uiGenerator = new PostCodeUiGenerator<PostCodeEntity, IControlEntity, ICodeBehindGenerator>();

            PostCodeControlGenerator postCodeControlGenerator = new PostCodeControlGenerator();

            foreach (var item in postCodeEntitys)
            {
                postCodeControlGenerator.Generate(item, null);
            }
            
            
        }

    }
}