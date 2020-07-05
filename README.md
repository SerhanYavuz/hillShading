# hillShading

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

 - Şimdilik oluşturulan random veri çok karmaşık görünsede pattern oluşturulduğunda (DTEDGenerator.GeneratePattern) algoritmanın çalıştığı görülebilir
 - Oluşturulan harita \bin\Debug\netcoreapp3.1\visualizedDTED.jpg konumuna kaydedilir
[X] verilen azimuth ve sunElevation değerlerine göre harita oluşturabiliyor 

## Complexity
