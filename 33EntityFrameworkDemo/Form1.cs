using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        UrunDal _urunDal = new UrunDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwUrunler.DataSource = _urunDal.Getir();
        }

        private void VerileriGetir()
        {
            dgwUrunler.DataSource = _urunDal.Getir();
        }

        private void AramaYap(string aranacak) //Bu method ile önce veritabanından veriler çekilir daha sonra gelen liste üzerinde where ve contains methodları ile arama yapılır.
        {
            dgwUrunler.DataSource = _urunDal.Getir().Where(p=>p.UrunAdi.Contains(aranacak)).ToList(); // Gelen ürünler içerisinden arama yapıyoruz. VERİTABANI İLE İLGİLİ BİR SORGULAMA İŞLEMİ YOK
        }


        private void btnKadet_Click(object sender, EventArgs e)
        {

            if(tbxUrunAdi.Text!="" && tbxUrunFiyat.Text!="" && tbxStokAdet.Text != "")
            {
                Urun EklenenUrun = new Urun
                {
                    UrunAdi = tbxUrunAdi.Text.ToString(),
                    UrunFiyat = Convert.ToDecimal(tbxUrunFiyat.Text),
                    StokAdet = Convert.ToInt32(tbxStokAdet.Text)
                };  // Urun tipinde bir EklenenUrun değişkeni oluşturuyoruz ve buna textboxlardan gelen değerleri alıyoruz.

                _urunDal.Ekle(EklenenUrun);  // _urunDal işlemindeki Ekle methodunu çağırıyoruz  ve oluşturduğumuz urun değişkenini ekleme methoduna parametre olarak gönderiyoruz.
                dgwUrunler.DataSource = _urunDal.Getir(); // _urunDal işlemindeki Getir methodunu çağırıyoruz veritabanında bulunan kayıtları çekiyoruz.  dgwUrunler gridviewimize datasoruce methodunu işliyoruz.

                MessageBox.Show("Kayıt eklendi .");

                tbxUrunFiyat.Text = "";
                tbxUrunAdi.Text = "";
                tbxStokAdet.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayın.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbxGuncelleUrunAdi.Text == "")
            {
                MessageBox.Show("Ürün adını lütfen boş bırakmayınız.");
            }
            else if (tbxGuncelleUrunFiyat.Text == "")
            {
                MessageBox.Show("Ürün fiyatını lütfen boş bırakmayınız.");
            }
            else if (tbxGuncelleStokAdet.Text == "")
            {
                MessageBox.Show("Ürün stok miktarını lütfen boş bırakmayınız.");
            }
            else
            {
                DuzenlemeIslemlerim();
            }

        }

        private void DuzenlemeIslemlerim()
        {
            Urun DuzenlenenUrun = new Urun
            {
                Id = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value),
                UrunAdi = tbxGuncelleUrunAdi.Text.ToString(),
                UrunFiyat = Convert.ToDecimal(tbxGuncelleUrunFiyat.Text),
                StokAdet = Convert.ToInt32(tbxGuncelleStokAdet.Text)
            };  // Urun tipinde bir EklenenUrun değişkeni oluşturuyoruz ve buna textboxlardan gelen değerleri alıyoruz.


            _urunDal.Duzenle(DuzenlenenUrun);  // _urunDal işlemindeki Düzenle methodunu çağırıyoruz  ve oluşturduğumuz urun değişkenini ekleme methoduna parametre olarak gönderiyoruz.
            dgwUrunler.DataSource = _urunDal.Getir(); // _urunDal işlemindeki Getir methodunu çağırıyoruz veritabanında bulunan kayıtları çekiyoruz.  dgwUrunler gridviewimize datasoruce methodunu işliyoruz.

            MessageBox.Show("Düzenleme işlemi yapıldı.");
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
        
            Urun silinenUrun = new Urun
            {
                Id = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value),
               
            };  // Urun tipinde bir EklenenUrun değişkeni oluşturuyoruz ve buna textboxlardan gelen değerleri alıyoruz.


            _urunDal.Sil(silinenUrun); // _urunDal işlemindeki Silme methodunu çağırıyoruz  ve oluşturduğumuz Urunid değişkenini silme methoduna parametre olarak gönderiyoruz.
            dgwUrunler.DataSource = _urunDal.Getir(); // _urunDal işlemindeki Getir methodunu çağırıyoruz veritabanında bulunan kayıtları çekiyoruz.  dgwUrunler gridviewimize datasoruce methodunu işliyoruz.
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxGuncelleUrunAdi.Text = dgwUrunler.CurrentRow.Cells[1].Value.ToString();  // Seçilen satırın ve ilgili hücrenin içeriğini alırız.
            tbxGuncelleUrunFiyat.Text = dgwUrunler.CurrentRow.Cells[2].Value.ToString(); // Seçilen satırın ve ilgili hücrenin içeriğini alırız.
            tbxGuncelleStokAdet.Text = dgwUrunler.CurrentRow.Cells[3].Value.ToString(); // Seçilen satırın ve ilgili hücrenin içeriğini alırız.
        }

        private void tbxArama_TextChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(tbxArama.Text);

            // AramaYap(tbxArama.Text); // Gelen data üzerinde arama yapar. c# küçük ve büyük harf duyarlıdır 

           //dgwUrunler.DataSource = _urunDal.Getir().Where(p => p.UrunAdi.Contains(tbxArama.Text)).ToList();


            dgwUrunler.DataSource = _urunDal.IsmeGoreGetir(tbxArama.Text);//Veritabanı üzerinde arama yapar 
        }

        private void tbxIdGetir_Click(object sender, EventArgs e)
        {
            if (tbxUrunId.Text != "")
            {
                var deger = _urunDal.IdGoreGetir(Convert.ToInt32(tbxUrunId.Text));
                if (deger != null)
                {
                    MessageBox.Show("Gelen ürün adı: " + deger.UrunAdi + ", ürün fiyatı: " + deger.StokAdet.ToString() + ", stok adeti: " + deger.UrunFiyat.ToString());

                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz id ye uygun ürün bulunamadı.");

                }
            }
            else
            {
                MessageBox.Show("Lütfen getirmek istediğiniz ürünün idsini giriniz.");
            }
         
        }

        private void btnFiyatFiltre_Click(object sender, EventArgs e)
        {

        }
    }
}
