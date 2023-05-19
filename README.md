[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/iGZu94G3)
# aw2

Asagida verilen modeli kullanarak GetAll, GetById , Put , Post , Delete methodlarini icen bir controller implement ediniz. 

EF ile generic repository ve UnitOfWork kullanabilirsiniz.

Put  ve Post apilerin de model validation hazirlayiniz.  Fluent validation kullaniniz. 

Extra olarak 2 tane alana gore (Query parameter) filtreleme yapan Filter apisi ekleyiniz (GET) ve WHERE sarti ile database den filtreleme yapiniz. 

Generic Repository uzerinde Where sartini implement ediniz. 

SOLID e uymaya ozen gosteriniz . 

Proje icerisinde sadece odev ile ilgili kisimlara yer veriniz. Kullanilmayan controller ve methodlari gondermeyiniz. Yorum satiri gondermeyininiz.

Model icin initial migration dosyasini ekleyiniz. 

Readme file uzerinde nasil calisacagina dair gerekli aciklamalara yer veriniz. 

Email alanini unique olmalidir. 

```
  public class Staff  
    { 
        public int Id { get; set; } 
        public string CreatedBy { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public string AddressLine1 { get; set; } 
        public string City { get; set; } 
        public string Country { get; set; } 
        public string Province { get; set; } 
        [NotMapped] 
        public string FullName 
        { 
            get { return FirstName + " " + LastName; } 
        } 
    }
```
# Simpra-.NET-Bootcamp-Homework2

## Projede Kullanınan Teknolojiler
.Net Core 6 Apı </br>
MSSQL</br>
Swagger UI </br>
Entity Framework Code First </br>
Repository Desing Pattern </br>
Onion Architecture </br>


## Entity Framework Code First</br>
Projede veri tabanı code first yaklaşımı ile yapılmıştır. Buradaki amaç veritabanı arayüzü ile etkileşimi minimize etmektir. Entity framework
Code Firts yaklaşımın en büyük avantajı projedeki modele tam hakimiyetle istediğimiz şekilde kullanmaktır.</br>
Projemde oluşturmuş olduğum Code First yaklaşımı şu şekilde;

![github](staff.png)


## Repository Desing Patern
Veri tabanını tasarlarken bir standart üzerine oluşturmayı hedefler.Veri tabanı işlemlerini yaparken yoğun bir tekrarlama ile karşılaşmakayız.İşte bu yüzden Repository
Desing Patern bu tekrarlama işlemlerini ortadan kaldırıp daha pratik bir şekilde bu işlemleri yapmamızı sağlamaktadır.</br>
Projemde oluşturmuş olduğum Repository Desing Patern şu şekilde;

![github](repo1.png)
![github](repo2.png)


## Onion Architecture 
Klasik n katmalı mimariden farkı katmanlar arasında gevşek bir bağ mevcuttur. Bu gevşek olan bağın sağladığı fayda ileride örneğin bir veri tabanı değiştirmek istediğimiz  zaman mssqlden mongodb veritabanına  geçiş yaptığımız taktirde n katmanlı mimariye göre daha az maliyetli ve kolaydır.
### Katmanlar
#### Domaim Katmanı
Etitylerle ilgili olan exceptionların tutulduğu katmandır.</br></br>
#### Core Katmanı
Domain ile iş katmanı arasında soyutlama katmanıdır. Tüm servis arayüzleri burada tanımlanır.</br></br>
#### Persistence Katmanı
Veri tabanı operasyonlarının ve veri erişimini yürüten katmandır.DbContext,Migration,Configurations gibi yapılar bu katmanda bulunur.</br></br>
#### Infrastructure Katmanı
Veri tabanı dışındaki operasyonları yürütür.</br></br>
#### Presentation Katmanı
Kullanıcının iletişim kurduğu katmandır.

Uyguladığım mimari şu şekilde;


![github](onion_architecture.png)




##  Genel Değerlendirme 

Bu haftaki eğitimde genel olarak mimari yapıları ve desing paternler üzerine göndermiş olduğunuz video serisinden bakarak uygulamaya çalıştım. Cqrs desing paternin mantığını tam karayamasamda uygulamaya çalıştım.Genel olarak verimli bir hafta oldu benim için ama ilerlemek öğrenmem gerek çok daha uzun bir zaman var önümde.Proje tam anlamıyla bitmiş değil.Karşılaştığım problemler üzerine hala çalışmaktayım.Bilgisayarımdan kaynaklı bazı hatalarım da mevcut. </br> </br>


Teşekkürler  :smile:
