using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                водительBindingSource.DataSource = db.Водитель.ToList();
                Update();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            водительBindingSource.DataSource = db.Водитель.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Водитель dv = (Водитель)водительBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись в таблице?  - " + dv.ID.ToString(), "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.(Question);
            if (dr == DialogResult.Yes)
            {
                db.Водитель.Remove(dv);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                водительBindingSource.DataSource = db.Водитель.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();

        }
    }
}
