# KÜTÜPHANE WEB UYGULAMASI

Kütüphanede bulunan kitapların takibi ve dışarıya verilebilmesi için bir kütüphane uygulaması geliştirildi.

## Proje Kriterleri

Uygulama veri tabanında bir tabloda bulunan kitapların şu an kütüphanede mi yoksa dışarıda mı olduğunu 
gösterildi.

Bu amaçla uygulamada kütüphanedeki kitapları listeleyen bir giriş ekranı yapıldı. Burada kitaplar alfabetik sırayla 
listelendi. Her listelenen kitabın adı, yazarı, resmi ve şu an kütüphanede mi yoksa dışarıda mı bulunduğu 
belirtildi.

Listelenen bir kitap ödünç verilmek istendiğinde “ödünç ver” düğmesine basılarak seçili kitap ödünç alanın ismi 
yazılarak ödünç verilebilebilir. Kitabın hangi tarihte geri getirileceği ödünç alana sorulabilmelir verilen cevap veri 
tabanına kaydedilebilir.

Uygulamada kütüphaneye yeni bir kitap eklemek için bir kitap ekle linki bulunmaktadır. Buradan eklenen yeni bir kitap 
resmi ile eklenebilir.

Uygulamada listelenen bir kitap üzerinde değişiklik yapma ve silme amacıyla herhangi bir şey yapılmamamıştır.
Değiştirme ve silme işlemleri doğrudan veri tabanı üzerindeki kayıtlara erişilerek yapılabilir.

ön yüzde gerekli hata kontrollerinin yapılması sağlanmıştır.

Uygulama içerisinde oluşabilecek exceptionlar için kontroller yapılmıştır.


## Teknik Gereklilikler
- .Net Core MVC 
- MSSQL 
- EFCore 
- HTML5, Bootstrap ve Jquery 

## Database
library.UI katmanı altında bulunan libraryScript.sql dosyasını çalıştırabilirsiniz.Çalıştırmadan önce aşağıdaki kodu çalıştırarak yeni bir database oluşturmalısınız.
appSettings.json dosyasında bulunan "Data Source" kısmına kendi local database isminizi vermelisiniz.
``` bash 
CREATE DATABASE LibraryDb





