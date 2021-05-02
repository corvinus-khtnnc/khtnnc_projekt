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
    public partial class UserControl1 : UserControl
    {
        //internal object dockstyle;
        TicketEntities context = new TicketEntities();

        public UserControl1()
        {
            InitializeComponent();
            SzindarabKeres();

            context.Szindarab.Load();
            szindarabBindingSource.DataSource = context.Szindarab.Local;

            context.Idopont.Load();
            idopontBindingSource.DataSource = context.Idopont.Local;
        }

        private void SzindarabKeres()
        {
            List<Szinhaz> szinhazlista= (from x in context.Szinhaz
                                           where x.Nev.Contains(textBox1.Text)
                                           orderby x.Nev
                                           select x).ToList();
            
            listBox1.DataSource = szinhazlista;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SzindarabKeres();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szinhaz szinhaz = (Szinhaz)listBox1.SelectedItem;

            var előadások = from x in context.Szindarab
                            where x.SzinhazFK == szinhaz.SzinhazSK
                            orderby x.Idopont.Kezdes
                            select x;
                            /*{
                                Színdarab = x.Cim,
                                Rendező = x.Rendezo,
                                Időpont = x.Idopont.Kezdes,
                                Műsoridő = x.Musorido
                            };*/

            dataGridView1.DataSource = előadások.ToList();
        }
    }
}
