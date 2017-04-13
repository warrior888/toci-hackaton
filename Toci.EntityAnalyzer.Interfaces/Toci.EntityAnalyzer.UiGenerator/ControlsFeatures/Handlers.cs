using System;
using System.Collections.Generic;

namespace Toci.EntityAnalyzer.UiGenerator.ControlsFeatures
{
    public abstract class Handlers 
    {
        public Dictionary<Type, Func<IList<string>>> TypeToHandlersMapper { get; set; }

        protected abstract IList<string> GetHandlers<T>();

    }
}