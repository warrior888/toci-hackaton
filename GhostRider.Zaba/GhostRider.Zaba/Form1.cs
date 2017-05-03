using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostRider.Zaba.Bll;
using GhostRider.Zaba.Bll.BusinessLogicLayer;

namespace GhostRider.Zaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getProductsButton_Click(object sender, EventArgs e)
        {
            ProductsBll bll = new ProductsBll();

            List<Products> products = bll.GetAllProducts();
            

            int i = 50;
            foreach (Products product in products)
            {
                AddProductToLayout(product, i);
                AddProductToLayoutbutton(product, i);
                i += 20;
            }
        }

        protected void AddProductToLayout(Products product, int y)
        {
            Label lb = new Label();

            lb.Text = product.Name;
            lb.Size = new Size(100, 20);
            lb.Location = new Point(10, y);
            lb.ForeColor = Color.DarkOrange;

            Controls.Add(lb);
        }
        protected void ProductFeaturesValue(ProductFeaturesValue PFValue, int y, int x)
        {
            Label lb = new Label();

            lb.Text = PFValue.Value;
            lb.Size = new Size(100, 20);
            lb.Location = new Point(x, y);

            Controls.Add(lb);
        }
        protected void AddProductToLayoutbutton(Products product, int y)
        {
            ProductButton button = new ProductButton(product.Id);

            button.Text = product.Name;
            button.Size = new Size(150, 20);
            button.Location = new Point(100, y);
            button.ForeColor = Color.CornflowerBlue;
            button.BackColor = Color.Yellow;

            button.Click += ProductButtonClick;

            Controls.Add(button);
        }

        private void ProductButtonClick(object sender, EventArgs e)
        {
            ProductsBll bll = new ProductsBll();
            List<ProductFeaturesValue> test = bll.GetProductFeaturesValuesForId(((ProductButton)sender).Id);

            ProductFeaturesValue(test[0], ((ProductButton)sender).Location.Y, ((ProductButton)sender).Location.X + 200);
        }
    }
}
