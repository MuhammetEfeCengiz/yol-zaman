using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yol_zaman
{
    public partial class Form1 : Form
    {
     

        private void hesapla2_btn_Click(object sender, EventArgs e)
        {
            int yol, zaman, hız;
            string cevap;

            zaman = Convert.ToInt32(zaman2_txt.Text);
            hız = Convert.ToInt32(hız2_txt.Text);
            yol = zaman * hız;
            cevap = yol.ToString();
            if (yol_cmb.Text == "cm")
            {
                cvp2_lbl.Text = yol * 100000 + " cm";
            }
            else if (yol_cmb.Text == "m")
            {
                cvp2_lbl.Text = yol * 1000 + " cm";
            }
            else if (yol_cmb.Text == "m")
            {
                cvp2_lbl.Text = yol * 1000 + " cm";
            }
            else
            {
                MessageBox.Show("Yol Türü Seçilmedi", "Tekrar Deneyin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            int yol, zaman, hız;
            string cevap;

            zaman = Convert.ToInt32(zaman_txt.Text);
            hız = Convert.ToInt32(hız_txt.Text);
            yol = zaman*hız;
            cevap = yol.ToString();
            cvp_lbl.Text = cevap+"km";
        }
    }
}
