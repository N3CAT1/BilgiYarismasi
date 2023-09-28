using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace BilgiYarismasi
{
    public partial class AnaForm : Form
    {
        int zamanSayac = 60, zamanSayac2 = 0;
        string enSonSoru = null;
        SoundPlayer sonBes = new SoundPlayer(Path.Combine(Application.StartupPath, "Sesler\\bubble_clap.wav"));
        SoundPlayer gong = new SoundPlayer(Path.Combine(Application.StartupPath, "Sesler\\gong.wav"));
        IniDosya ini = new IniDosya(Path.Combine(Application.StartupPath, "Ayarlar.ini"));

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo dinf = new DirectoryInfo(Path.Combine(Application.StartupPath, "Sorular"));
            FileInfo[] fi = dinf.GetFiles();

            for ( int i = 0; i < fi.Length; i++ )
            {
                lbSorular.Items.Add("SORU " + fi[i].Name.Replace(fi[i].Extension, ""));
            }
        }

        private void lblZamanSayac_Click(object sender, EventArgs e)
        {
            int index = lbSorular.SelectedIndex;

            DirectoryInfo dinf = new DirectoryInfo(Path.Combine(Application.StartupPath, "Sorular"));
            FileInfo[] fi = dinf.GetFiles();
            pBoxSoru.ImageLocation = fi[index].FullName;

            enSonSoru = lbSorular.Items[index].ToString();
            zamanSayac2 = zamanSayac;
            lblCevap.Text = "";
            timerSayac.Enabled = true;
        }

        private void timerSayac_Tick(object sender, EventArgs e)
        {
            zamanSayac2 = zamanSayac2 - 1;
            if ( zamanSayac2 != 0 )
            {
                if ( zamanSayac2 < 10 )
                    lblZamanSayac.Text = "0" + zamanSayac2.ToString();
                else
                    lblZamanSayac.Text = zamanSayac2.ToString();

                if ( zamanSayac2 <= 5 )
                    sonBes.Play();
            }
            else if ( zamanSayac2 == 0 )
            {
                gong.Play();
                timerSayac.Enabled = false;
                lblZamanSayac.Text = "0" + zamanSayac2.ToString();
                lblMesaj.Text = "Lütfen cevaplarınızı kaldırınız";
            }
        }

        private void btnZamanGeri_Click(object sender, EventArgs e)
        {
            if ( timerSayac.Enabled == true )
                return;
            if ( zamanSayac > 15 )
                zamanSayac = zamanSayac - 15;
            lblZamanSayac.Text = zamanSayac.ToString();
        }

        private void btnZamanIleri_Click(object sender, EventArgs e)
        {
            if ( timerSayac.Enabled == true )
                return;
            //if ( zamanSayac < 60 )
            zamanSayac = zamanSayac + 15;
            lblZamanSayac.Text = zamanSayac.ToString();
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            lblCevap.Text = ini.IniReadValue("SoruCevaplari", enSonSoru.Replace(" ", "_").Substring(0,7));
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            pBoxSoru.Image = null;
            lblCevap.Text = "";
            timerSayac.Enabled = false;
            zamanSayac = 60;
            lblZamanSayac.Text = zamanSayac.ToString();
            lblMesaj.Text = "";
        }
    }
}
