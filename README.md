# Kurumsal Mimaride ASP.NET Core
[Engin Demiroğ](https://www.linkedin.com/in/engindemirog/) ve [Mustafa Murat Coşkun](https://www.linkedin.com/in/mustafa-murat-co%C5%9Fkun-428858b9/)'a ait web programlama [udemy kursunun](https://www.udemy.com/course/komple-sifirdan-web-gelistirme-kursu/) konuları arasında bulunan Kurumsal Mimaride ASP:NET Core kullanımı kapsamında hazırlanmış projedir. 

## Kullanılan Teknolojiler
C# Programlama dili ile kodlanan proje ASP.NET Core 3.1 ile hazırlanmıştır. Hazır veri tabanları arasında bulunan Northwind veri tabanı MS SQL Server ile açılmış proje içerisindeki gibi entegre edilmiştir ve işlemler bu veri tabanındaki veriler ile gerçekleştirilmiştir.

### Proje ve Eğitim Bilgileri
Katmanlı mimari ile hazırlanan proje boyunca Nesne Yönelimli Programlama yöntemleri ve SOLID prensipleri temel alınmıştır.

### Katman Bilgileri
Hazırlanan projede kurumsal mimari kullanıldığından belirtilen katmanlar oluşturulmuştur.
- **Entity:** Varlık anlamındaki entity veri tabanındaki tabloların ve join durumundaki tabloların bilgilerinin bulunduğu katmandır.
- **DataAccess:** Veri tabanındaki verilerin Backend de kullanmak üzerine erişiminin sağlandığı katmandır.
- **Business:** İş katmanı olarak adlandırdığımız katman, ekle, sil, güncelle gibi işlemlerin kodlarının yazıldığı katmandır.
- **Core:** Core katmanında sadece bu proje için değil, farklı projelerde de birebir kullanılabilecek kodların barındırılması sağlanmıştır.
- **MvcWebUI:** Hazırlanan katmanların, veri tabanı işlemlerinin kullanıcı ile etkileşiminin sağlandığı katmandır.
