using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace CounterStkikeF5C
{
    public partial class Oyun : Form
    {
        Dictionary<int, Silah> silahlarim = new Dictionary<int, Silah>();
        SoundPlayer snd = new SoundPlayer();
        Silah seciliSilah; //her seferınde nesne türetmek yerine bir kere burada tanımladım.
        SoundPlayer olumSesi = new SoundPlayer();
        public Oyun()
        { //Application.StartupPath : Uygulamanın çalıştığı dizini döner.
            InitializeComponent();
            string Dizinler = Application.StartupPath; // ARALARA NEDEN DİZİNLER VE APPLİCATİON STARUP YAZMAK GEREKIYOR SOR 
            silahlarim.Add(0, new Bazuka(2, "Bazuka", @"silahFoto\Bazuka.png", Dizinler + "\\BazukaAtes.wav", Dizinler + "\\BazukaDoldur.wav"));
            silahlarim.Add(1, new Tabanca(14, "Tabanca", @"silahFoto\Tabanca.png", Dizinler + "\\TabancaAtes.wav", Dizinler + "\\TabancaDoldur.wav"));
            silahlarim.Add(2, new Taramali(30, "Taramali", @"silahFoto\Taramali.png", Dizinler + "\\TaramaliAtes.wav", Dizinler + "\\TaramaliDoldur.wav"));
            silahlarim.Add(3, new Tank(1, "Tank", @"silahFoto\Tank.png", Dizinler + "\\TankAtes.wav", Dizinler + "\\TankDoldur.wav"));
            silahlarim.Add(4, new Sniper(6, "Sniper", @"silahFoto\Sniper.png", Dizinler + "\\SniperAtes.wav", Dizinler + "\\SniperDoldur.wav"));
            silahlarim.Add(5, new Pompali(4, "Pompali", @"silahFoto\Pompali.png", Dizinler + "\\PompaliAtes.wav", Dizinler + "\\PompaliDoldur.wav"));
            silahlarim.Add(6, new Bicak(3, "Bicak", @"silahFoto\Bicak.png", Dizinler + "\\BicakSaldir.wav", Dizinler + "\\BicakBileyle.wav"));
            silahDegistir(silahlarim[0]); // form açıldıgında bu gelsin yani bazuka
        }
        void silahDegistir(Silah degistirilecekSilah)
        {
            //   seciliSilah //sınıftan türettiğim nesne. buradan keyleri dğeiştirince formdakı controlleri silahlara göre dğeişiricem.
            seciliSilah = degistirilecekSilah;
            progressBar_mermi.Maximum = seciliSilah.ToplamMermi;
            progressBar_mermi.Value = seciliSilah.SuankiMemri;
            pictureBox_silah.Image = Image.FromFile(seciliSilah.SilahGorselPath);//fotoğraf yolunu aldım.
            label_silahAd_SilahMermi.Text = seciliSilah.SilahAd + "|" + seciliSilah.ToplamMermi;

            if (seciliSilah is Bicak)
            {
                btn_atesEt.Text = "ATTACK";
                btn_doldur.Text = "SHARPEN";
            }
            else
            {
                btn_atesEt.Text = "FIRE";
                btn_doldur.Text = "RELOAD";
            }
        }
        void muzikCal(string Dizin)
        {
            snd.SoundLocation = Dizin;
            snd.Play();
        }
        private void Oyun_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D1)
            {
                silahDegistir(silahlarim[0]); //silahlarım listesinden 0 anahtarına D1(1)i atadık. 1 e basınca 0 anahtarında ne varsa o görünecek
            }
            else if (e.KeyData == Keys.D2)
            {
                silahDegistir(silahlarim[1]);
            }
            else if (e.KeyData == Keys.D3)
            {
                silahDegistir(silahlarim[2]);
            }
            else if (e.KeyData == Keys.D4)
            {
                silahDegistir(silahlarim[3]);
            }
            else if (e.KeyData == Keys.D5)
            {
                silahDegistir(silahlarim[4]);
            }
            else if (e.KeyData == Keys.D6)
            {
                silahDegistir(silahlarim[5]);
            }
            else if (e.KeyData == Keys.D7)
            {
                silahDegistir(silahlarim[6]);
            }
        }
        private void btn_atesEt_Click(object sender, EventArgs e)
        {
            if (seciliSilah.atesEt())
            {
                muzikCal(seciliSilah.AtesSesiPath);
                progressBar_mermi.Value = seciliSilah.SuankiMemri;
                label_silahAd_SilahMermi.Text = seciliSilah.SilahAd + "|" + seciliSilah.SuankiMemri;
            }
            if (seciliSilah.SuankiMemri == 0)
            {
                if (seciliSilah is Bicak)
                {
                    DialogResult mesaj = MessageBox.Show(seciliSilah.SilahAd + " Bileyle!");
                    if (mesaj == DialogResult.OK || mesaj == DialogResult.Yes || mesaj == DialogResult.Cancel)
                    {
                        snd.Stop();
                        SoundPlayer olumSesi = new SoundPlayer();
                        olumSesi.SoundLocation = "cokCiddiÖlümSesi.wav";
                        olumSesi.Play();
                        MessageBox.Show("ÖLDÜRÜLDÜ!");
                    }
                }
                else
                {
                    DialogResult mesaj = MessageBox.Show(seciliSilah.SilahAd + " Mermilerini Doldur!");
                    if (mesaj == DialogResult.OK || mesaj == DialogResult.Yes || mesaj == DialogResult.Cancel)
                    {
                        snd.Stop();
                        olumSesi.SoundLocation = "cokCiddiÖlümSesi.wav";
                        olumSesi.Play();
                        MessageBox.Show("ÖLDÜRÜLDÜ!");
                    }
                }
            }
        }
        private void btn_doldur_Click(object sender, EventArgs e)
        {
            muzikCal(seciliSilah.DoldurmaSesiPath);
            progressBar_mermi.Value = progressBar_mermi.Maximum;
            label_silahAd_SilahMermi.Text = seciliSilah.SilahAd + "|" + seciliSilah.ToplamMermi;
            seciliSilah.SuankiMemri = seciliSilah.ToplamMermi;
        }
    }
}
