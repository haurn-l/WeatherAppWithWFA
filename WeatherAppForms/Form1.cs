using System;
using System.Windows.Forms;
using WeatherAppForms.Models;   
using WeatherAppForms.Services;

namespace WeatherAppForms
{
    public partial class Form1 : Form
    {
        private readonly WeatherService _havaDurumuServisi = new WeatherService();
        public Form1()
        {
            InitializeComponent();
        }

   
        private async void btnAra_Click(object sender, EventArgs e)
        {
            string sehir = txtSehir.Text;

            if (string.IsNullOrWhiteSpace(sehir))
            {
                MessageBox.Show("Lütfen geçerli bir şehir adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnAra.Enabled = false;
            btnAra.Text = "Aranıyor...";

            WeatherResponse sonuc = await _havaDurumuServisi.GetWeatherAsync(sehir);

            if (sonuc != null)
            {
                lblSehirAdi.Text = $"Şehir: {sonuc.SehirAdi.ToUpper()}";
                lblSicaklik.Text = $"Gerçek Sıcaklık: {sonuc.AnaVeriler.Sicaklik:0.00} °C";
                lblHissedilen.Text = $"Hissedilen Sıcaklık: {sonuc.AnaVeriler.Hissedilen:0.00} °C";
            }
            else
            {
                MessageBox.Show("Şehir bulunamadı veya bağlantı hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnAra.Enabled = true;
            btnAra.Text = "Hava Durumunu Getir";
        }
    }
}
