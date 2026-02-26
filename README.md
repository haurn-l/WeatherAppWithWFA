# 🌦️ C# Hava Durumu Uygulaması (Windows Forms UI)

Bu proje, **OpenWeatherMap API** kullanarak canlı hava durumu verilerini çeken ve kullanıcıya modern bir masaüstü arayüzü (GUI) ile sunan bir C# Windows Forms uygulamasıdır. 

Projenin kalbi, daha önce geliştirilen konsol uygulamasının sağlam asenkron backend mimarisi üzerine inşa edilmiştir. `Models` (DTO) ve `Services` katmanları arayüzden tamamen izole edilerek temiz kod (Clean Code) prensiplerine uyulmuştur.

## 🚀 Özellikler
* **Görsel Kullanıcı Arayüzü (UI):** Kullanıcı dostu arama çubuğu (TextBox) ve anlık sonuç ekranı.
* **Asenkron Programlama:** Veri çekilirken arayüzün (pencerenin) donmasını engellemek için `HttpClient` ve `async/await` mimarisi kullanılmıştır.
* **JSON Serialization:** `System.Text.Json` kütüphanesi ile API'den gelen karmaşık JSON verileri otomatik olarak C# nesnelerine (DTO) dönüştürülür.
* **Hata Yönetimi:** Geçersiz şehir adı girişleri veya internet bağlantısı kopukluklarına karşı kullanıcıya özel uyarı pencereleri (MessageBox) çıkarılır.

## 🛠️ Kullanılan Teknolojiler
* C# / .NET (Windows Forms)
* OpenWeatherMap API
* Nesne Yönelimli Programlama (OOP) ve Katmanlı Mimari Tasarımı

## 📖 Nasıl Çalıştırılır?
1. Bu depoyu bilgisayarınıza klonlayın veya `.zip` olarak indirin.
2. [OpenWeatherMap](https://openweathermap.org/) üzerinden ücretsiz bir API anahtarı edinin.
3. Visual Studio'da projeyi açın ve `Services/WeatherService.cs` dosyasına giderek `_apiKey` alanına kendi gizli anahtarınızı yapıştırın.
4. Üstteki "Start" butonuna basarak projeyi derleyip çalıştırın.

---
*Not: Bu proje, backend servislerinin farklı kullanıcı arayüzlerine (Console -> UI) kod israfı olmadan nasıl entegre edilebileceğini test etmek amacıyla geliştirilmiştir.*
