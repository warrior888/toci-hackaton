using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.ControlsFeatures
{
    public abstract class Handlers 
    {
        public Dictionary<Type, Func<IList<string>>> TypeToHandlersMapper { get; set; }

        protected abstract IList<string> GetHandlers<T>();

    }
}