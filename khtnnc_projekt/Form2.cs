using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khtnnc_projekt
{
    public partial class Form2 : Form
    {
        TicketEntities context = new TicketEntities();
        
        public Form2()
        {
            InitializeComponent();
            context.Vevo.Load();

        }

        private bool CheckTeljesNev (string teljesnév)
        {
            Regex r = new Regex(@"^(?!\s*$).+");
            return !string.IsNullOrEmpty(teljesnév);
        }

        private bool CheckEletkor(string életkor)
        {
            Regex r = new Regex(@"(^[1-9]{1}$)|(^[1-9][0-9]$)");
            return r.IsMatch(életkor);
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckTeljesNev(textBoxNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNev, "Nincs ilyen név!");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNev, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEletkor(textBoxEletkor.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEletkor, "Ez nem lehet életkor érték!");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEletkor, "");
        }


        //---------------------------------------------

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CheckTeljesNev(textBoxNev.Text))
            {
                textBoxNev.BackColor = Color.LightGreen;
            }

            else
            {
                textBoxNev.BackColor = Color.LightCoral;
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (CheckEletkor(textBoxEletkor.Text))
            {
                textBoxEletkor.BackColor = Color.LightGreen;
            }

            else
            {
                textBoxEletkor.BackColor = Color.LightCoral;
                button1.Enabled = false;
            }
        }
    }
}
