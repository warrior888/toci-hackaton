using System;
using System.Linq;
using System.Text;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.CodeBehind
{
    public class WpfCodeBehindGenerator : CodeBehindGenerator
    {
        public override ICodeBehindEntity Generate(IComplexProperty complexProperty)
        {
            Type propertyType = complexProperty.Entity.FieldType;
            Type genericType = typeof(WpfCodeBehindEntity<>).MakeGenericType(propertyType);
            var codeBehindEntity = (ICodeBehindEntity)Activator.CreateInstance(genericType, complexProperty.Entity.Name);
            Filter(codeBehindEntity, complexProperty);
            return codeBehindEntity;
        }
        protected override string GenerateSkeleton(IComplexEntity complexEntity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(
                "using System.Windows;" + Environment.NewLine +
                "" + Environment.NewLine +
                "namespace {AppName}" + Environment.NewLine +
                "{" + Environment.NewLine +
                "" + Environment.NewLine +
                "	public partial class {EntityName}Window: Window" + Environment.NewLine +
                "	{" + Environment.NewLine +
                "" + Environment.NewLine +
                "		public {EntityName} Entity {get; set;}" + Environment.NewLine +
                "" + Environment.NewLine +
                "		public {EntityName}Window(IRepository<{EntityName}> {EntityNameToLower}Repository, {EntityName} entity)" +
                Environment.NewLine +
                "		{" + Environment.NewLine +
                "			InitializeComponent();" + Environment.NewLine +
                "			Entity = entity ?? new {EntityName}();" + Environment.NewLine +
                "" + Environment.NewLine +
                "		}" + Environment.NewLine +
                "" + Environment.NewLine +
                "		{Handlers}" + Environment.NewLine +
                "" + Environment.NewLine +
                "	}" + Environment.NewLine +
                "}");
            string typeNameWithoutNamespace = complexEntity.Name;
            stringBuilder.Replace("{AppName}", typeNameWithoutNamespace);
            stringBuilder.Replace("{EntityName}", typeNameWithoutNamespace);
            stringBuilder.Replace("{EntityNameToLower}", typeNameWithoutNamespace.ToLower());
            return stringBuilder.ToString();
        }

        protected void Filter(ICodeBehindEntity codeBehindEntity, IComplexProperty complexProperty)
        {
            //some filtering logic on codeBehindEntity.Handlers and Properties, to get rid of unnecessary
            //filtering based on constraints, FODF, LFFF etc from complexProperty
        }
    }
}