using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.ControlsFeatures;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Data
{
    public class WpfCodeBehindEntity<T> : ICodeBehindEntity
    {
        public string Name { get; set; }
        //store properties that way, so the most important is first
        //or have some connections dictionary to store which handler changes what
        public IList<string> Properties { get; set; }
        public IList<string> Handlers { get; set; }
        public WpfCodeBehindEntity(string name)
        {
            Name = name;
            var handlers = new WpfHandlers();
            Handlers = handlers.TypeToHandlersMapper[typeof(T)].Invoke();
        }

        public string Materialize()
        {
            var stringBuilder = new StringBuilder();
            foreach (var handler in Handlers)
            {
                stringBuilder.Append(Environment.NewLine +
                                "		private void {PropertyName}_{HandlerName}(object sender, RoutedEventArgs e)" + Environment.NewLine +
                                "		{" + Environment.NewLine +
                                "			entity.{PropertyName} = {PropertyName}.{ControlProperty};" + Environment.NewLine +
                                "		}" + Environment.NewLine);
                stringBuilder.Replace("{HandlerName}", handler);
                stringBuilder.Replace("{PropertyName}", Name);
                //this is shit, but we need to know which handler is connected to which property
                //but we can have more dependencies :/ any ideas? MainPropertyAttribute/?/
                //F.E. For textbox main property is Text, for checkbox IsChecked, for DatePicker - SelectedDate etc.
                stringBuilder.Replace("{ControlProperty}", Properties.First());
            }
            return stringBuilder.ToString();
        }
    }
}