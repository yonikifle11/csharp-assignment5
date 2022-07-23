using System.Text.RegularExpressions;

namespace updateform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(tbnum.Text))
            {
                errorProvider1.SetError(tbnum, "Number is required");
            }
            else if (string.IsNullOrEmpty(tbinvnum.Text))
            {
                errorProvider1.SetError(tbinvnum, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(tbobjName.Text))
            {
                errorProvider1.SetError(tbobjName, "Object name is required");
            }
            else if (string.IsNullOrEmpty(tbcount.Text))
            {
                errorProvider1.SetError(tbcount, "Count is required");
            }
            else if (string.IsNullOrEmpty(tbprice.Text))
            {
                errorProvider1.SetError(tbprice, "Price is required");
            }
            else if (!r.IsMatch(tbobjName.Text))
            {
                errorProvider1.SetError(tbobjName, "String should not have numbers.");
            }
            else
            {



                try
                {
                    Class1 p = new Class1()
                    {
                        number = tbnum.Text,
                        objectName = tbobjName.Text,
                        InventoryNumber = tbinvnum.Text,
                        count = tbcount.Text,
                        price = tbprice.Text,
                    };
                    p.save();
                    DGV.DataSource = null;
                    DGV.DataSource = Class1.GetAllProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("type mismatch");
                };

            }

            
        }
    }
}