using System;
using System.Linq;
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
            var codeBehindEntity = (ICodeBehindEntity)Activator.CreateInstance(genericType);
            return codeBehindEntity;
        }
        protected override string GenerateSkeleton(Type type)
        {
            //todo: set AppName {AppName}
            string skeleton =
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
                "}";
            string typeNameWithoutNamespace = type.ToString().Split('.').Last();
            skeleton = skeleton.Replace("{EntityName}", typeNameWithoutNamespace);
            skeleton = skeleton.Replace("{EntityNameToLower}", typeNameWithoutNamespace.ToLower());
            return skeleton;
        }


    }
}