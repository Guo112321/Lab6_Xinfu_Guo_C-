using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int itemNo = int.Parse(txtItemNo.Text);
                string discription = txtDescription.Text;
                double price = double.Parse(txtPrice.Text);

                Item item = new Item(itemNo, discription, price);
                form1.list.Add(item);
                form1.UpdateListBox(form1.list);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtItemNo.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
        }
    }
}
