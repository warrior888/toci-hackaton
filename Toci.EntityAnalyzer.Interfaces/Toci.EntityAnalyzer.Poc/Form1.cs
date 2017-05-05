using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toci.EntityAnalyzer.Entities.Parsing;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Tools;
using Toci.EntityAnalyzer.Tools;
using Toci.EntityAnalyzer.Tools.PostCodeParser;

namespace Toci.EntityAnalyzer.Poc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateForm();
        }

        protected virtual void GenerateForm()
        {
            IFIleParser<TextFileSource, IParseResult> test = new PostCodeTextFileParser<TextFileSource, PostCodeEntity>();

            var parsed = test.Parse(new TextFileSource { FilePath = @"Z:\", FileName = "kody.csv" });

            Entities Db = new Entities();

            

            int i = 20;
            foreach (var element in parsed)
            {
                Label lb = new Label();

                lb.Location = new Point(20, i += 20);
                lb.Size = new Size(300, 20);
                Controls.Add(lb);

                lb.Text = ((PostCodeEntity) element).Province + ((PostCodeEntity)element).PostCode;

                TextBox tb = new TextBox();

                tb.Location = new Point(500, i);
                tb.Size = new Size(300, 20);
                Controls.Add(tb);

                tb.Text = ((PostCodeEntity) element).Address;

                if (i > 300) break;


                Db.PostCodes.Add(new PostCodes
                {
                    PostCode = ((PostCodeEntity)element).PostCode
                });
            }

            Db.SaveChanges();
        }
    }
}
