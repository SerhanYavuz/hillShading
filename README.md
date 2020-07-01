# hillShading
hill shading algorithm and visualization 

Hillshading Algoritması

Bu algoritmanın amacı arazi modelinin gölgelendirilerek 3-boyutlu görünüm veren bir doku oluşturulmasıdır.

 

DTED Verisi: (Digital Terrain Elevation Data)

DTED Verisi arazi yüksekliklerini modellemek için kullanılmaktadır.

Literatürde 2,5 (iki buçuk) boyutlu veri olarak geçer.

Temel olarak arasında eşit mesafeler bulunan noktalardaki yükseklik/rakım verilerinden oluşmaktadır.

Örneğin her 90 metre x 90 metre'lik bir alan için bir tane arazi yüksekliği bulunur, diyelim ki 110 metre olsun. Bu yükseklik deniz seviyesinden yüksekliği verir.

2-boyutlu bir matrisin / veya array'in herbir elemanı bir yüksekliği ifade eder.

 

int dted[1201][1201];

dted[0][0] = 110 metre.

dted[0][1] = 112 metre.

gibi..

DTED verisi kullanılarak örneğin bir uçuş simülatörü uygulamasında dünya modeli oluşturulabilir.

Bu modele doku vermek için ise hillshade map ile doku imajı oluşturulabilir.

 

int dted[3][3] = {

A1 A2 A3

B1 B2 B3

C1 C2 C3 

} olsun.

Burada herbir eleman arazide bir noktadır. Değeri ise rakımı yani deniz seviyesinden yüksekliğidir.

 

Assignment:

1- 401 * 401 'lik DTED verisi oluşturulması (rastgele-düzenli veri/veya internetten örnek DTED arazi modeli bulabilirsin ancak parse etmek gerekebilir).

2- Internetten hillshade map algoritması bulup Java'ya port edilmesi/ veya doğrudan Java algoritması bulunması.

3- Algoritmanın çalıştırılarak hillshade map oluşturulması.

4- Çıktının görselleştirilmesi.

5- 3-5 tane girdi/çıktı ile algoritmanın çalıştığının gösterilmesi.

6- algoritmanın karmaşıklık analizi. 

 

Öncelikle anlamadığın soruları sor.
