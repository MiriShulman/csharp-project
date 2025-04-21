using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class AddProductForm : Form
    {
        public Product p { get; set; }
        public AddProductForm(string title)
        {
            InitializeComponent();
            Title.Text = title;
            ExpDate.MinDate = DateTime.Now;
            CategoryCombo.DataSource = Enum.GetValues(typeof(Categories));
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            bool flag = true;
            p = new Product(ByWeightCB.Checked);
            try
            {
                p.Name = NameTB.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(NameTB, ex.Message);
            }
            p.ExpDate = ExpDate.Value;
            //הערך מגיע מטיפוס decimal ומצריך המרה מפורשת
            p.Price = (double)PriceNum.Value;
            p.Category = (Categories)CategoryCombo.SelectedItem;
            if (flag)
            {
                //Form1.Products[Form1.Index++] = p;
                //סגירת המסך
                this.Close();
                MessageBox.Show("המוצר נוסף בהצלחה");
                DialogResult d = MessageBox.Show("המוצר נוסף בהצלחה", "הודעה", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }
    }
}
