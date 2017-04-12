using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.ControlsFeatures
{
    public class WpfProperties : Properties
    {
        public const string IsEnabled = "IsEnabled";
        public const string Content = "Content";
        public const string Text = "Text";

        public WpfProperties()
        {
            TypeToPropertiesMapper = new Dictionary<Type, Func<IList<string>>>()
            {
                { typeof(string), GetProperties<TextBox> }
            };
        }

        protected override IList<string> GetProperties<T>()
        {
            var controlProperties = typeof(T).GetProperties();
            var supportedProperties = GetType().GetFields(BindingFlags.Static | BindingFlags.Public);
            return supportedProperties.Join(controlProperties, propertyInfo => propertyInfo.Name,
                controlPropertyInfo => controlPropertyInfo.Name, (propertyInfo, controlPropertyInfo) => propertyInfo.Name).ToList();
        }
    }
}