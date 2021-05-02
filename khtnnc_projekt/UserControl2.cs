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
    public partial class UserControl2 : UserControl
    {
        TicketEntities context = new TicketEntities();
        
        public UserControl2()
        {
            InitializeComponent();
            Vevőszűrés();
            context.Rendelesi_tetel.Load();
            context.Rendeles.Load();
            context.Jegytipus.Load();
            context.Szindarab.Load();
            rendelesitetelBindingSource.DataSource = context.Rendelesi_tetel.Local;            
            rendelesBindingSource.DataSource = context.Rendeles.Local;            
            jegytipusBindingSource.DataSource = context.Jegytipus.Local;            
            szindarabBindingSource.DataSource = context.Szindarab.Local;
        }

        private void Vevőszűrés()
        {
            var vevők = from x in context.Vevo
                        where x.Teljes_nev.StartsWith(textBox1.Text)
                        orderby x.Teljes_nev
                        select x;

            listBox1.DataSource = vevők.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Vevőszűrés();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vevo vevo = (Vevo)listBox1.SelectedItem;

            var rendelések = from x in context.Rendeles
                             where x.VevoFK == vevo.VevoSK
                             orderby x.Rend_datum
                             select x;
            listBox2.DataSource = rendelések.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            rendelesitetelBindingSource.EndEdit();

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
