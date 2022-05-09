using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32AdoNetDemo
{
    public partial class Form1 : Form
    {

        UrunDal _urunDal = new UrunDal(); //Ürün ile ilgili veritabanı işlemlerini tuttuğumuz urunDal classına referans göstererek değişkenimizi oluşturuyoruz.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwUrunler.DataSource = _urunDal.Getir(); // _urunDal işlemindeki Getir methodunu çağırıyoruz veritabanında bulunan kayıtları çekiyoruz.  dgwUrunler gridviewimize datasoruce methodunu işliyoruz.
        }

        private void btnKadet_Click(object sender, EventArgs e)
        {
            Urun EklenenUrun = new Urun {
                UrunAdi = tbxUrunAdi.Text.ToString(),
                UrunFiyat = Convert.ToDecimal(tbxUrunFiyat.Text), 
                StokAdet = Convert.ToInt32(tbxStokAdet.Text) 
            };  // Urun tipinde bir EklenenUrun değişkeni oluşturuyoruz ve buna textboxlardan gelen değerleri alıyoruz.

            _urunDal.Ekle(EklenenUrun);  // _urunDal işlemindeki Ekle methodunu çağırıyoruz  ve oluşturduğumuz urun değişkenini ekleme methoduna parametre olarak gönderiyoruz.




            dgwUrunler.DataSource = _urunDal.Getir(); // _urunDal işlemindeki Getir methodunu çağırıyoruz veritabanında bulunan kayıtları çekiyoruz.  dgwUrunler gridviewimize datasoruce methodunu işliyoruz.



            MessageBox.Show("Kayıt eklendi .");
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("Satır Seçildi.");
    
            tbxGuncelleUrunAdi.Text = dgwUrunler.CurrentRow.Cells[1].Value.ToString() ;
            tbxGuncelleUrunFiyat.Text = dgwUrunler.CurrentRow.Cells[2].Value.ToString() ;
            tbxGuncelleStokAdet.Text = dgwUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        //private void dgwUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show("Hücre Seçildi .");
        //}




        private void button1_Click(object sender, EventArgs e)
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
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
           int Urunid = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value);
          
            _urunDal.Sil(Urunid); // _urunDal işlemindeki Silme methodunu çağırıyoruz  ve oluşturduğumuz Urunid değişkenini silme methoduna parametre olarak gönderiyoruz.
            dgwUrunler.DataSource = _urunDal.Getir(); // _urunDal işlemindeki Getir methodunu çağırıyoruz veritabanında bulunan kayıtları çekiyoruz.  dgwUrunler gridviewimize datasoruce methodunu işliyoruz.
        }

   
    }
}
