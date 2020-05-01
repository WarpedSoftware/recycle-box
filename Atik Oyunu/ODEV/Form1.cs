
/* Melih FIRAT G191210380 2C Nesneye Dayali Programlama Atik Oyunu */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ODEV.Properties;
namespace ODEV
{
    // Yazdigim kodda classlar variablelar vs. hep ayni siralamada gidiyor daha okunabilir olmasi icin. 
    public partial class Form1 : Form
    {
        //Kagit Atiklar Atik Class'ından miras alır IAtik interface'inden bilgileri alır.
        Gazete gazete = new Gazete();
        Dergi dergi = new Dergi();

        //Metal Atiklar Atik Class'ından miras alır IAtik interface'inden bilgileri alır.
        DomatesKutusu domatesKutusu = new DomatesKutusu();
        KolaKutusu kolaKutusu = new KolaKutusu();

        //Organik Atiklar Atik Class'ından miras alır IAtik interface'inden bilgileri alır.
        Domates domates = new Domates();
        Salata salata = new Salata();

        //Cam Atiklar Atik Class'ından miras alır IAtik interface'inden bilgileri alır.
        Bardak bardak = new Bardak();
        Camsise camSise = new Camsise();

        //Atık Kutularım Dolabilen Class'ından miras alır, IAtikKutusu : IDolabilen' interfacelerinden bilgileri alır.
        KagitAtikKutusu kagitAtik = new KagitAtikKutusu();
        MetalAtikKutusu metalAtik = new MetalAtikKutusu();
        OrganikAtikKutusu organikAtik = new OrganikAtikKutusu();
        CamAtikKutusu camAtik = new CamAtikKutusu();
        
        Random rnd = new Random();

        //Windows kütüphanesinden bir zamanlayıcı çağırdım ki geriye sayım işlemimi yapayım.
        System.Timers.Timer t;

        int sure=60;     
        int random;
        int puan = 0;

        public Form1()
        {
            InitializeComponent();                   
            //TextBox'ların yazılmasını engelliyorum.
            time_baslik_text.ReadOnly = true;
            puan_baslik_text.ReadOnly = true;
            kutular_baslik.ReadOnly = true;
        }

        private void baslat_button_Click(object sender, EventArgs e)
        {
            puan = 0;
            puanText.Text = Convert.ToString(puan);

            //Oyun bittiğinde kapanan tuşları geri etkin hale getirir.
           
            kagit_bosalt.Enabled = true;
            metal_bosalt.Enabled = true;
            organik_bosalt.Enabled = true;
            cam_bosalt.Enabled = true;
            
            kagit_ekle_button.Enabled = true;
            metal_ekle_button.Enabled = true;
            organik_ekle_button.Enabled = true;
            cam_ekle_button.Enabled = true;

            //Oyunu tekrar tekrar başlatmak geri sayımı bozan bi hataya sebep açıyor bu bir debug.
            baslat_button.Enabled = false;

            sure = 60;

            random = rnd.Next(1, 9);
            switch (random)
            {
                case 1: my_image.Image = bardak.Image; break;
                case 2: my_image.Image = camSise.Image; break;
                case 3: my_image.Image = domates.Image; break;
                case 4: my_image.Image = domatesKutusu.Image; break;
                case 5: my_image.Image = gazete.Image; break;
                case 6: my_image.Image = kolaKutusu.Image; break;
                case 7: my_image.Image = salata.Image; break;
                case 8: my_image.Image = dergi.Image; break;
            }
            my_image.Visible = true;
            
            t = new System.Timers.Timer();
            //1000 1 saniyede 1 çalışmasını temsil ediyor 1000ms;
            t.Interval = 1000;
            t.Elapsed += OntimeEvent;
            t.Start();

            puan = 0;
            puanText.Text = Convert.ToString(puan);
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            t.Stop();
            sure = 60;
            zamanSayaci.Text = Convert.ToString(sure);

            puanText.Text = Convert.ToString(puan);
            
            //Oyunu kapattiginizda butun ekran temizleniyor.
            kagit_list.Text = "";
            metal_list.Text = "";
            organik_list.Text = "";
            cam_list.Text = "";

           //Oyunu kapattiginizda butun kapasite eski haline donuyor.
            kagitAtik.Kapasite = 1200;
            metalAtik.Kapasite = 2300;
            organikAtik.Kapasite = 700;
            camAtik.Kapasite = 2200;

            //Progress Barlar temizleniyor
            kagit_yuzde.Value = 0;
            metal_yuzde.Value = 0;
            organik_yuzde.Value = 0;
            cam_yuzde.Value = 0;
           
            //Baslat butonu disindaki butun tuslarin erisimi kapaniyor.
            baslat_button.Enabled = true;
          
            kagit_bosalt.Enabled = false;
            metal_bosalt.Enabled = false;
            organik_bosalt.Enabled = false;
            cam_bosalt.Enabled = false;
         
            kagit_ekle_button.Enabled = false;
            metal_ekle_button.Enabled = false;
            organik_ekle_button.Enabled = false;
            cam_ekle_button.Enabled = false;
        }
        private void kagit_bosalt_click(object sender, EventArgs e)
        {
            if (kagitAtik.Bosalt())
            {
                puan += kagitAtik.BosaltmaPuani;
                puanText.Text = Convert.ToString(puan);
                kagitAtik.Kapasite = 1200;
                kagit_yuzde.Value = 0;
                sure += 3;
                kagit_list.Text = "";
            }
        }
        private void metal_bosalt_click(object sender, EventArgs e)
        {
            if (metalAtik.Bosalt())
            {
                puan += metalAtik.BosaltmaPuani;
                puanText.Text = Convert.ToString(puan);
                metalAtik.Kapasite = 2300;
                metal_yuzde.Value = 0;
                sure += 3;
                metal_list.Text = "";
            }
        }
        private void organik_bosalt_Click(object sender, EventArgs e)
        {
            if (organikAtik.Bosalt())
            {
                puan += organikAtik.BosaltmaPuani;
                puanText.Text = Convert.ToString(puan);
                organikAtik.Kapasite = 700;
                organik_yuzde.Value = 0;
                sure += 3;
                organik_list.Text = "";
            }
        }
        private void cam_bosalt_Click(object sender, EventArgs e)
        {
            if (camAtik.Bosalt())
            {
                puan += camAtik.BosaltmaPuani;
                puanText.Text = Convert.ToString(puan);
                camAtik.Kapasite = 2200;
                cam_yuzde.Value = 0;
                sure += 3;
                cam_list.Text = "";
            }
        }
        private void kagit_ekle_button_Click(object sender, EventArgs e)
        {
            if (kagitAtik.Ekle(dergi) && random == 8 && ((100 * (kagitAtik.DoluHacim - (kagitAtik.Kapasite - dergi.Hacim)) / kagitAtik.DoluHacim) < 100))
            {
                puan += dergi.Hacim;
                puanText.Text = Convert.ToString(puan);
                kagitAtik.Kapasite -= dergi.Hacim;
                kagit_yuzde.Value = 100 * (kagitAtik.DoluHacim - kagitAtik.Kapasite) / kagitAtik.DoluHacim;
                kagit_list.Text += "Dergi (200p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }
            }
            if (kagitAtik.Ekle(gazete) && random == 5 && ((100 * (kagitAtik.DoluHacim - (kagitAtik.Kapasite - gazete.Hacim)) / kagitAtik.DoluHacim) < 100))
            {
                puan += gazete.Hacim;
                puanText.Text = Convert.ToString(puan);
                kagitAtik.Kapasite -= gazete.Hacim;
                kagit_yuzde.Value = 100 * (kagitAtik.DoluHacim - kagitAtik.Kapasite) / kagitAtik.DoluHacim;
                kagit_list.Text += "Gazete (250p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }
            }

        }

        private void metal_ekle_button_Click(object sender, EventArgs e)
        {
            //&& ((100 * (metalatik.DoluHacim - (metalatik.Kapasite - domateskutusu.Hacim)) / metalatik.DoluHacim) < 100)
            if (metalAtik.Ekle(domatesKutusu) && random == 4 &&  ((100 * (metalAtik.DoluHacim - (metalAtik.Kapasite - domatesKutusu.Hacim)) / metalAtik.DoluHacim) < 100))
            {
                puan += domatesKutusu.Hacim;
                puanText.Text = Convert.ToString(puan);
                metalAtik.Kapasite -= domatesKutusu.Hacim;
                metal_yuzde.Value = 100 * (metalAtik.DoluHacim - metalAtik.Kapasite) / metalAtik.DoluHacim;
                metal_list.Text += "Salça Kutusu (550p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }
            }
            //&& ((100 * (metalatik.DoluHacim - (metalatik.Kapasite - kolakutusu.Hacim)) / metalatik.DoluHacim) < 100)
            if (metalAtik.Ekle(kolaKutusu) && random == 6 &&  ((100 * (metalAtik.DoluHacim - (metalAtik.Kapasite - kolaKutusu.Hacim)) / metalAtik.DoluHacim) < 100))
            {
                puan += kolaKutusu.Hacim;
                puanText.Text = Convert.ToString(puan);
                metalAtik.Kapasite -= kolaKutusu.Hacim;
                metal_yuzde.Value = 100 * (metalAtik.DoluHacim - metalAtik.Kapasite) / metalAtik.DoluHacim;
                metal_list.Text += "Kutu Kola (350p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }

            }

        }
        private void organik_ekle_button_Click(object sender, EventArgs e)
        {
            if (organikAtik.Ekle(domates) && random == 3 && ((100 * (organikAtik.DoluHacim - (organikAtik.Kapasite - domates.Hacim)) / organikAtik.DoluHacim) < 100))
            {
                puan += domates.Hacim;
                puanText.Text = Convert.ToString(puan);
                organikAtik.Kapasite -= domates.Hacim;
                organik_yuzde.Value = 100 * (organikAtik.DoluHacim - organikAtik.Kapasite) / organikAtik.DoluHacim;
                organik_list.Text += "Domates (150p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }
            }
            if (organikAtik.Ekle(salata) && random == 7 && ((100 * (organikAtik.DoluHacim - (organikAtik.Kapasite - salata.Hacim)) / organikAtik.DoluHacim) < 100))
            {
                puan += salata.Hacim;
                puanText.Text = Convert.ToString(puan);
                organikAtik.Kapasite -= salata.Hacim;
                organik_yuzde.Value = 100 * (organikAtik.DoluHacim - organikAtik.Kapasite) / organikAtik.DoluHacim;
                organik_list.Text += "Salatalık (120p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }
            }

        }
        
        private void cam_ekle_button_Click(object sender, EventArgs e)
        {

            if (camAtik.Ekle(bardak) && random == 1 && ((100 * (camAtik.DoluHacim - (camAtik.Kapasite - bardak.Hacim)) / camAtik.DoluHacim) < 100)
)
            {
                puan += bardak.Hacim;
                puanText.Text = Convert.ToString(puan);
                camAtik.Kapasite -= bardak.Hacim;
                cam_yuzde.Value = 100 * (camAtik.DoluHacim - camAtik.Kapasite) / camAtik.DoluHacim;
                cam_list.Text += "Bardak (250p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }
            }
            if (camAtik.Ekle(camSise) && random == 2 && ((100 * (camAtik.DoluHacim - (camAtik.Kapasite - camSise.Hacim)) / camAtik.DoluHacim) < 100))
            {
                puan += camSise.Hacim;
                puanText.Text = Convert.ToString(puan);
                camAtik.Kapasite -= camSise.Hacim;
                cam_yuzde.Value = 100 * (camAtik.DoluHacim - camAtik.Kapasite) / camAtik.DoluHacim;
                cam_list.Text += "Cam Şişe (600p)\n";
                random = rnd.Next(1, 9);
                switch (random)
                {
                    case 1: my_image.Image = bardak.Image; break;
                    case 2: my_image.Image = camSise.Image; break;
                    case 3: my_image.Image = domates.Image; break;
                    case 4: my_image.Image = domatesKutusu.Image; break;
                    case 5: my_image.Image = gazete.Image; break;
                    case 6: my_image.Image = kolaKutusu.Image; break;
                    case 7: my_image.Image = salata.Image; break;
                    case 8: my_image.Image = dergi.Image; break;
                }

            }
        }

        

        private void OntimeEvent(object sender, ElapsedEventArgs e) // sayac ve sayacin bitiminde yapilacak islemler
        {
            Invoke(new Action(() =>
            {
                if (sure != 0)
                {
                    sure -= 1;
                    if (sure == 0)
                    {
                        baslat_button.Enabled = true;
                        organik_bosalt.Enabled = false;
                        kagit_bosalt.Enabled = false;
                        metal_bosalt.Enabled = false;
                        cam_bosalt.Enabled = false;
                        organik_ekle_button.Enabled = false;
                        kagit_ekle_button.Enabled = false;
                        metal_ekle_button.Enabled = false;
                        cam_ekle_button.Enabled = false;
                    }
                }
                zamanSayaci.Text = Convert.ToString(sure);
            }
            ));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
public interface IAtik
{
    int Hacim { get; }
    System.Drawing.Image Image { get; }
}
public interface IAtikKutusu : IDolabilen
{
    /// <summary>
    /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
    /// </summary>
    int BosaltmaPuani { get; }
    /// <summary>
    /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.
    /// </summary>
    /// <param name="atik">Eklenecek Atık</param>
    /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>
    //bool Ekle(Atik atik); //BU KODUN NEDEN HATA VERDİĞİNİ BİLMİYORUM AMA KODUMDA ERROR GÖZÜKMESİ HOŞUMA GİTMEDİĞİNDEN BUNU DISABLE YAPTIM

    /// <summary>
    /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
    /// </summary>
    /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>
    bool Bosalt();
}
public interface IDolabilen
{
    int Kapasite { get; set; }
    int DoluHacim { get; }
    int DolulukOrani { get; }
}

class Dolabilen : IDolabilen, IAtikKutusu
{
    private int _kapasite;
    private int _doluHacim;
    private int _dolulukOrani;
    private int _bosaltmaPuani;
    public int Kapasite { get {return _kapasite; }  set {_kapasite = value; } }
    public int DoluHacim { get {return _doluHacim; } }
    public int DolulukOrani { get {return _dolulukOrani; } }

   public int BosaltmaPuani { get {return _bosaltmaPuani; } }
    public bool Ekle(Atik atik)
    {
        if (((100 * (DoluHacim - (Kapasite - atik.Hacim)) / DoluHacim) < DolulukOrani+25))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Bosalt()
    {
        if (100 * (DoluHacim - Kapasite) / DoluHacim >= DolulukOrani)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class KagitAtikKutusu : Dolabilen
{
    private int _kapasite = 1200;
    private int _doluhacim = 1200;
    private int _dolulukorani = 75;
    private int _bosaltmapuani = 1000;
    public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }
    public int DoluHacim { get { return _doluhacim; } }
    public int DolulukOrani { get { return _dolulukorani; } }

    public int BosaltmaPuani { get { return _bosaltmapuani; } }
    public bool Ekle(Atik atik)
    {
        if (((100 * (DoluHacim - (Kapasite - atik.Hacim)) / DoluHacim) < 100))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool Bosalt()
    {
        if (100 * (DoluHacim - Kapasite) / DoluHacim >= 75)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class MetalAtikKutusu : Dolabilen
{
    private int _kapasite = 2300;
    private int _doluhacim = 2300;
    private int _dolulukorani=75;
    private int _bosaltmapuani = 800;
    public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }
    public int DoluHacim { get { return _doluhacim; } }
    public int DolulukOrani { get { return _dolulukorani; } }

    public int BosaltmaPuani { get { return _bosaltmapuani; } }
   
    public bool Ekle(Atik atik)
    {
        if (((100 * (DoluHacim - (Kapasite - atik.Hacim)) / DoluHacim) < 100))
        {
            return true;
        }      
        else
        {
            return false;
        }
    }

    public bool Bosalt()
    {
        if (100 * (DoluHacim - Kapasite) / DoluHacim >= 75)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class OrganikAtikKutusu : Dolabilen
{
    private int _kapasite = 700;
    private int _doluhacim = 700;
    private int _dolulukorani = 75;
    private int _bosaltmapuani = 0;
    public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }
    public int DoluHacim { get { return _doluhacim; } }
    public int DolulukOrani { get { return _dolulukorani; } }

    public int BosaltmaPuani { get { return _bosaltmapuani; } }
    public bool Ekle(Atik atik)
    {
        if (((100 * (DoluHacim - (Kapasite - atik.Hacim)) / DoluHacim) < 100))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool Bosalt()
    {
        if (100 * (DoluHacim - Kapasite) / DoluHacim >= 75)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class CamAtikKutusu : Dolabilen
{
    private int _kapasite = 2200;
    private int _doluhacim = 2200;
    private int _dolulukorani=75;
    private int _bosaltmapuani = 600;
    public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }
    public int DoluHacim { get { return _doluhacim; } }
    public int DolulukOrani { get { return _dolulukorani; } }

    public int BosaltmaPuani { get { return _bosaltmapuani; } }
    Atik atik;
    public bool Ekle(Atik atik)
    {
        if (((100 * (DoluHacim - (Kapasite - atik.Hacim)) / DoluHacim) < 100))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Bosalt()
    {
        if (100 * (DoluHacim - Kapasite) / DoluHacim >= 75)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Atik : IAtik
{
    private int _hacim;
    private System.Drawing.Image _image;
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}

class Gazete : Atik
{
    private int _hacim = 250;
    private System.Drawing.Image _image = Image.FromFile("gazete.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}

class Dergi : Atik
{
    private int _hacim = 200;
    private System.Drawing.Image _image = Image.FromFile("dergi.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}

class DomatesKutusu : Atik
{
    private int _hacim = 550;
    private System.Drawing.Image _image = Image.FromFile("domateskutusu.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}



class KolaKutusu : Atik
{
    private int _hacim = 350;
    private System.Drawing.Image _image = Image.FromFile("kolakutusu.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}

class Domates : Atik
{
    private int _hacim = 150;
    private System.Drawing.Image _image = Image.FromFile("domates.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}


class Salata : Atik
{
    private int _hacim = 120;
    private System.Drawing.Image _image = Image.FromFile("salata.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}

class Bardak : Atik
{
    private int _hacim = 250;
    private System.Drawing.Image _image = Image.FromFile("bardak.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}

class Camsise : Atik
{
    private int _hacim = 600;
    private System.Drawing.Image _image = Image.FromFile("camsise.png");
    public int Hacim
    {
        get { return _hacim; }
    }

    public System.Drawing.Image Image { get { return _image; } }
}



