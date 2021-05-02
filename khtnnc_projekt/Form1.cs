﻿using System;
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
    public partial class Form1 : Form
    {
        TicketEntities context = new TicketEntities();

        public Form1()
        {
            InitializeComponent();
            context.Vevo.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new UserControl2();
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            
            /*if (f2.ShowDialog() == DialogResult.OK)
            {
                Vevo v = new Vevo();
                v.Teljes_nev = f2.textBoxNev.Text;
                v.Eletkor = int.Parse(f2.textBoxEletkor.Text);
                context.Vevo.Add(v);

                context.SaveChanges();
            }*/
        }
    }
}
