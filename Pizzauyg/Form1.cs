using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzauyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbkenar.Items.Add("İnce Kenar");
            cmbkenar.Items.Add("Normal Kenar");
            cmbkenar.Items.Add("Kalın Kenar");
            cmbboyut.Items.Add("Küçük");
            cmbboyut.Items.Add("Orta");
            cmbboyut.Items.Add("Büyük");
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            try
            {
                pizza pizzaorder = new pizza();
                pizzaorder.kenar = cmbkenar.Text;
                if (pizzaorder.kenar == "")
                {
                    throw new Exception("Kenar Tipi seçmek zorunludur");
                }
                pizzaorder.boyut = cmbboyut.Text;
                if (pizzaorder.boyut == "")
                {
                    throw new Exception("Kenar Tipi seçmek zorunludur");
                }

                int malzemeadedi = 0;
                string malzemeismi = string.Empty;

                if (checkmlzm1.Checked)
                {
                    malzemeadedi++;
                    malzemeismi = checkmlzm1.Text;
                }
                if (checkmlzm2.Checked)
                {
                    malzemeadedi++;
                    malzemeismi += "," + checkmlzm2.Text;
                }
                if (checkmlzm3.Checked)
                {
                    malzemeadedi++;
                    malzemeismi += "," + checkmlzm3.Text;
                }
                if (checkmlzm4.Checked)
                {
                    malzemeadedi++;
                    malzemeismi += "," + checkmlzm4.Text;
                }
                if (checkmlzm5.Checked)
                {
                    malzemeadedi++;
                    malzemeismi += "," + checkmlzm5.Text;
                }
                pizzaorder.malzemeadedi = malzemeadedi;
                pizzaorder.malzeme = malzemeismi;

                pizzaorder.icecek = checkicecek.Checked;
                pizzaorder.tatli = checktatli.Checked;
                MessageBox.Show(pizzaorder.siparistutari());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
