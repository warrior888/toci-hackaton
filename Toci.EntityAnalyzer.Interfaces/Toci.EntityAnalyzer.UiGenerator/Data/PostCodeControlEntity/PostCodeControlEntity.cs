using System.Collections.Generic;
using System.Windows.Forms;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data.PostCodeControlEntity;

namespace Toci.EntityAnalyzer.UiGenerator.Data.PostCodeControlEntity
{
    public class PostCodeControlEntity : ControlEntity, IPostCodeControlEntity
    {
        public TextBox TextBox { get; set; }

        public PostCodeControlEntity(string name)
        {
            TextBox = new TextBox {Text = name};
        }
        
    }
}