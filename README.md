# 🏥 Hastane Randevu Sistemi

Bu proje, C# ve MySQL kullanılarak geliştirilmiş bir **Hastane Randevu Yönetim Sistemi**dir. Uygulama üç farklı kullanıcı tipi için giriş ve kontrol imkânı sunar: **Sekreter**, **Doktor**, ve **Hasta**. Amaç, hastane süreçlerini dijital ortamda daha düzenli ve hızlı bir şekilde yürütmektir.

## 🚀 Özellikler

### 1. Giriş Türleri
- **Sekreter Girişi**
  - Randevu oluşturma
  - Doktor listesi düzenleme
  - Branş tanımlama
  - Günlük randevu listelerini görüntüleme

- **Doktor Girişi**
  - Kendi randevularını görme
  - Randevuya gelen hastaların şikayetlerini ve tedavi bilgilerini görüntüleme
  - Hasta hakkında not ekleme

- **Hasta Girişi**
  - Mevcut randevularını görüntüleme
  - Yeni randevu oluşturma
  - Randevu geçmişini görüntüleme

## 🛠️ Teknolojiler

- **Frontend / Arayüz:** Windows Forms (C#)
- **Veritabanı:** MySQL

## 🗃️ Veritabanı Yapısı

**Tablolar:**
- `kullanicilar`: Kullanıcı bilgileri (hasta, doktor, sekreter)
- `doktorlar`: Branş ve doktor bilgileri
- `randevular`: Randevu detayları (tarih, saat, doktor, hasta)
- `branslar`: Branş tanımları
- `hasta_gecmis`: Hasta geçmiş kayıtları
