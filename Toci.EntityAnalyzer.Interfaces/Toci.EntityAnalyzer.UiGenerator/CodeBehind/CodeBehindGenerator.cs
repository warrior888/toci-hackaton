using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.CodeBehind
{
    public abstract class CodeBehindGenerator : ICodeBehindGenerator
    {
        public abstract ICodeBehindEntity Generate(IComplexProperty complexProperty);

        protected abstract string GenerateSkeleton(Type type);
    }
}