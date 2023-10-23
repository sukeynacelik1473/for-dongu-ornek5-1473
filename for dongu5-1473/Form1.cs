using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongu5_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();

            int sayi1 = Convert.ToInt32(txtSayı1.Text);
            int sayi2 = Convert.ToInt32(txtSayı2.Text);
            int sayi3 = Convert.ToInt32(txtSayı3.Text);

            //yazdırma
            for (int i = sayi1; i <= sayi2; i += sayi3)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
