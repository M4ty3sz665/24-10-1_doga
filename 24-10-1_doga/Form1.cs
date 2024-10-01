using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_10_1_doga
{
    public partial class Form1 : Form
    {
        dbhandler db;
        products oneProduct = new products();
        public Form1()
        {
           
            InitializeComponent();
            db = new dbhandler();
           

            //db.addOne(oneProduct);
            //db.deleteOne(oneProduct);

            start();
        }

        public void start()
        {
            update();
            addButton.Click += (s, e) =>
            {
                listBox1.Items.Add("Név:"+nameTExt.Text +" mennyi:"+ quantityText.Text +" Ár:"+ priceText.Text);

                
                oneProduct.name = nameTExt.Text.ToString();
                oneProduct.quantity = Convert.ToInt32(quantityText.Text);
                oneProduct.price = Convert.ToInt32(priceText.Text);
                db.addOne(oneProduct);
            };
            deleteButton.Click += (s, e) =>
            {
                int asd = listBox1.SelectedIndex;
                try
                {
                    db.deleteOne(products.product[asd]);
                }
                catch (Exception)
                {

                    MessageBox.Show("error");
                }
                update();
                
            };
        }
        public void update()
        {
            products.product.Clear();
            db.readAll();
            listBox1.Items.Clear();
            foreach (products item in products.product)
            {
                listBox1.Items.Add($"Név: {item.name}  mennyi:{item.quantity}  Ár:{item.price} ");
            }
        }

    }
}
