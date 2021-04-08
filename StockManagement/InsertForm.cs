using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
          
            
            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;
                p.Honey = comboBox2.Text;
                p.Quantity = Double.Parse(QuantityBox.Text);
                p.Year = int.Parse(textBox1.Text);
              
           
      
            
            SqliteDataAccess.SavePerson(p);
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = String.Empty;

            }
            comboBox2.ResetText();
        }
        private void QuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && QuantityBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

       
    }
}

