using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Form1 : Form
    {
        
        DataTable People = new DataTable();
        public Form1()
        {
            InitializeComponent();
            LoadPeople();
        }

        private void LoadPeople()
        {
            People = SqliteDataAccess.LoadPeople();
            WireUpPeople();
            

        }

        private void LoadAcacia()
        {
            People = SqliteDataAccess.LoadAcacia();
            WireUpPeople();
        }
       
        private void LoadLime()
        {
            People = SqliteDataAccess.LoadLime();
            WireUpPeople();
        }
        private void LoadSunflower()
        {
            People = SqliteDataAccess.LoadSunflower();
            WireUpPeople();
        }
        private void LoadPolyFloral()
        {
            People = SqliteDataAccess.LoadPolyFloral();
            WireUpPeople();
        }
        private void WireUpPeople()
        {
            dataView.DataSource = null;
            dataView.DataSource = People;
         
        }
   
   
        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control c in panel3.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.Empty;
            }
            bt.BackColor = Color.FromArgb(44, 59, 69);
            LoadAcacia();
            if (dataView.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to display for column " + "Acacia");
            }
        }

        

       




        private void LimeButton_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control c in panel3.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.Empty;
            }
            bt.BackColor = Color.FromArgb(44, 59, 69);
            LoadLime();
            if (dataView.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to display for column " + "Lime");
            }
        }
        private void sunflowerButton_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control c in panel3.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.Empty;
            }
            bt.BackColor = Color.FromArgb(44, 59, 69);
            LoadSunflower();
            if (dataView.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to display for column " + "Sunflower");
            }

        }

        private void polyfloralButton_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control c in panel3.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.Empty;
            }
            bt.BackColor = Color.FromArgb(44, 59, 69);
            LoadPolyFloral();
            if (dataView.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to display for column "+ "Polyfloral");
            }
            
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertForm formInsert = new InsertForm();
            formInsert.Show();
        }

        private void honeyButton_Click(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
                SqliteDataAccess.DeletePerson(dataView);
            else
                MessageBox.Show("Please select a value!");
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
