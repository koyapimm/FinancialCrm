# C# Eğitim Kampı - Financial CRM Projesi

Bu proje, C# Eğitim Kampı kapsamında geliştirilen, kullanıcıların finansal durumlarını, banka hesaplarını ve faturalarını yönetebildikleri, veritabanı destekli ve grafiksel arayüze sahip kapsamlı bir **Masaüstü Finansal Yönetim (CRM)** uygulamasıdır.

## 🎯 Projenin Amacı

Proje; C# programlama dili ve **Windows Forms** kullanılarak, ilişkisel veritabanı (MSSQL) üzerinde **CRUD** (Ekleme, Okuma, Güncelleme, Silme) işlemlerini gerçekleştirmeyi ve verileri anlamlı grafiklerle (Chart) kullanıcıya sunmayı hedefler. Ayrıca modern UI tasarımı ve formlar arası veri taşıma yeteneklerini pekiştirmek amacıyla geliştirilmiştir.

## 🖼️ Proje Görselleri ve Modüller

### 1. Giriş Ekranı (Login)
Kullanıcı güvenliği için oluşturulan giriş paneli. Veritabanındaki `Users` tablosunda kayıtlı bilgiler doğrulanarak sisteme giriş yapılır.

<img width="1150" height="650" alt="login" src="https://github.com/user-attachments/assets/4fdedf0f-f627-4304-923b-27ee228a22f9" />

### 2. Dashboard (Genel Bakış)
Kullanıcının finansal durumunu özetleyen ana ekran.
* **Grafikler:** Banka bakiyeleri ve fatura durumları dinamik **Chart** araçlarıyla görselleştirilmiştir.
* **İstatistikler:** Toplam bakiye, son gelen havale gibi veriler anlık olarak hesaplanır.
* 
<img width="1147" height="651" alt="dashboard" src="https://github.com/user-attachments/assets/fedd7c01-c13a-49db-ad05-baff184c7227" />

### 3. Banka Hareketleri ve Bakiye Takibi
Tüm banka hesaplarının bakiyelerinin görüntülendiği ve geçmiş işlem hareketlerinin (Gelen/Giden Havale) listelendiği modüldür.

<img width="1148" height="655" alt="banks" src="https://github.com/user-attachments/assets/394818f8-2299-4189-9ba8-acff9e2100d6" />

<img width="1147" height="651" alt="bankprocesses" src="https://github.com/user-attachments/assets/41079bb6-2cad-4ba6-bf63-6223d87fa140" />

### 4. Fatura Yönetimi (Billing)
Elektrik, su, internet gibi düzenli ödemelerin takip edildiği ekran.
* Yeni fatura ekleme, düzenleme ve silme işlemleri buradan yapılır.
* Ödeme periyotları ve miktarları veritabanına kaydedilir.

<img width="1147" height="648" alt="bills" src="https://github.com/user-attachments/assets/aa696faa-ce1c-4a4f-9d19-60bab4a275c4" />

### 5. Ayarlar
Kullanıcı şifre işlemlerinin ve kişisel ayarların güncellendiği bölüm.

<img width="1147" height="648" alt="settings" src="https://github.com/user-attachments/assets/46d49bb8-4cb3-4bc0-a680-940662e8787e" />

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET Framework (Windows Forms)
* **Veritabanı:** Microsoft SQL Server
* **Veri Erişimi:** Entity Framework (Code First / Db First) & ADO.NET (Modüle göre değişiklik gösterebilir)
* **Görselleştirme:** MS Chart Controls
* **Mimari:** N-Tier Architecture (veya proje yapına göre Monolith)

## 📂 Veritabanı Yapısı (Özet)

Proje aşağıdaki temel tablolar üzerine kuruludur:
1.  **Banks:** Banka isimleri ve genel bakiye bilgileri.
2.  **BankProcesses:** Hesap hareketleri (Gelen/Giden para, Tarih, Açıklama).
3.  **Bills:** Fatura türü, miktarı ve ödeme periyodu.
4.  **Spendings:** Gider kalemleri.
5.  **Categories:** İşlem kategorileri.
6.  **Users:** Yönetici/Kullanıcı giriş bilgileri.

## 🚀 Kurulum Adımları

1.  Projeyi bilgisayarınıza indirin (Clone).
2.  SQL Server üzerinde veritabanını oluşturun (Script veya EF Migration ile).
3.  `app.config` veya bağlantı sınıfındaki `connection string` bilgisini kendi sunucunuza göre düzenleyin.
4.  Projeyi Visual Studio üzerinden başlatın.

---
*Bu proje koyapimm tarafından C# Eğitim Kampı sürecinde geliştirilmiştir.*
