using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.ControlsConsts
{
    public static class Handlers
    {
        public const string IsEnabledChanged = "IsEnabledChanged";
        public const string LostFocus = "LostFocus";
        public const string TextChanged = "TextChanged";

        public static Dictionary<Type, Func<IList<string>>> TypeToHandlersMapper = new Dictionary
            <Type, Func<IList<string>>>()
            {
                { typeof(string), GetHandlers<TextBox> }
            };

        private static IList<string> GetHandlers<T>() where T : Control
        {
            var controlHandlers = typeof(T).GetEvents();
            var supportedHandlers = typeof(Handlers).GetFields(BindingFlags.Static | BindingFlags.Public);
            return supportedHandlers.Join(controlHandlers, propertyInfo => propertyInfo.Name,
                eventInfo => eventInfo.Name, (propertyInfo, eventInfo) => propertyInfo.Name).ToList();
        }
    }
}