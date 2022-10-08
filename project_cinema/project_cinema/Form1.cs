using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam ;
            misir = Convert.ToInt16(txtMisir.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay=Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            toplam = (misir * 15) + (su * 5) + (cay * 4) + (bilet * 25);
            lblToplam.Text = toplam.ToString() + "TL";
            txtMisir.Text = misir.ToString();
            txtSu.Text = su.ToString();
            txtCay.Text = cay.ToString();
            txtBilet.Text= bilet.ToString();

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + "TL";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            lblToplam.Text = "0.00TL";
            txtMisir.Focus();
        }
    }
}
