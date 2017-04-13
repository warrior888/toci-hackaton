using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;

namespace Toci.EntityAnalyzer.UiGenerator.ControlsFeatures
{
    public class WpfHandlers : Handlers
    {
        public const string IsEnabledChanged = "IsEnabledChanged";
        public const string LostFocus = "LostFocus";
        public const string TextChanged = "TextChanged";

        public WpfHandlers()
        {
            TypeToHandlersMapper = new Dictionary<Type, Func<IList<string>>>()
            {
                { typeof(string), GetHandlers<TextBox> }
            };
        }

        protected override IList<string> GetHandlers<T>()// where T: Control
        {
                var controlHandlers = typeof(T).GetEvents();
                var supportedHandlers = GetType().GetFields(BindingFlags.Static | BindingFlags.Public);
                return supportedHandlers.Join(controlHandlers, propertyInfo => propertyInfo.Name,
                    eventInfo => eventInfo.Name, (propertyInfo, eventInfo) => propertyInfo.Name).ToList();
        }
    }
}