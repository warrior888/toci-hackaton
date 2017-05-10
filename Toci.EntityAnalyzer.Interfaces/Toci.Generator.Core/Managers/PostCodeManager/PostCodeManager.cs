using System.Collections.Generic;
using System.Runtime.InteropServices;
using Toci.EntityAnalyzer.Entities.Parsing;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Tools.PostCodeParser;
using Toci.EntityAnalyzer.UiGenerator.Controls.PostCodeControlGenerator;
using Toci.EntityAnalyzer.UiGenerator.Data.PostCodeControlEntity;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data.PostCodeControlEntity;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers.PostCodeUiGenerator;
using Toci.EntityAnalyzer.UiGenerator.Managers;
using Toci.EntityAnalyzer.UiGenerator.Managers.PostCodeUiGenerator;
using Toci.Generator.Core.Interfaces.Managers.PostCodeManager;

namespace Toci.Generator.Core.Managers.PostCodeManager
{
    public class PostCodeManager : IPostCodeManager
    {
        private readonly PostCodeTextFileParser<TextFileSource, PostCodeEntity> _parseResult = new PostCodeTextFileParser<TextFileSource, PostCodeEntity>();
        public IEnumerable<IPostCodeEntity> PostCodeEntitys { get; set; }
        private readonly List<PostCodeControlEntity> _controlEntitiesList = new List<PostCodeControlEntity>();
        private readonly PostCodeUiGenerator<IPostCodeControlEntity, ICodeBehindGenerator> _uiGenerator = new PostCodeUiGenerator<IPostCodeControlEntity, ICodeBehindGenerator>();
        private readonly PostCodeControlGenerator<IPostCodeEntity, ICodeBehindEntity> _postCodeControlGenerator = new PostCodeControlGenerator<IPostCodeEntity, ICodeBehindEntity>();

        public PostCodeManager(string filePath, string fileName)
        {
            ITextFileSource source = new TextFileSource { FilePath = filePath, FileName = fileName};
            PostCodeEntitys = _parseResult.Parse((TextFileSource)source);
        }
        
        protected void GetGeneratedUi(List<PostCodeControlEntity> controlList)
        {
            foreach (var item in controlList)
            {
                _uiGenerator.GenerateUi(item, null);
            }
        }

        protected void GetGeneratedControlEntitieslist(IEnumerable<IPostCodeEntity> postCodeEntitys)
        {
            foreach (var item in postCodeEntitys)
            {
                _controlEntitiesList.Add((PostCodeControlEntity)_postCodeControlGenerator.Generate(item, null));
            }
        }
        public void Generate()
        {
            GetGeneratedControlEntitieslist(PostCodeEntitys);
            GetGeneratedUi(_controlEntitiesList);

        }


    }
}