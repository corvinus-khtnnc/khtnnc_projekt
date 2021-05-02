using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khtnnc_projekt
{
    public partial class Form3 : Form
    {
        TicketEntities context = new TicketEntities();
        
        public Form3()
        {
            InitializeComponent();

            context.Vevo.Load();
            vevoBindingSource.DataSource = context.Vevo.Local;

            button1.Text = "\uE710";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                Vevo v = new Vevo();
                v.Teljes_nev = f2.textBoxNev.Text;
                v.Eletkor = int.Parse(f2.textBoxEletkor.Text);
                vevoBindingSource.Add(v);

                context.SaveChanges();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            vevoBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            dataGridView1.Refresh();
        }
    }
}
