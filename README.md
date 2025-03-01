# Akademi 2

1-	•  Metot (Fonksiyon) nedir?
2-	•  Metotları neden kullanırız?
3-	•  Geriye değer döndüren (return kullanan) metot ile void metot arasındaki fark nedir?
4-	•  Metotların parametreleri nasıl çalışır?

Metot Nedir ve Neden Kullanırız: Metotlar diğer bir değişle fonksiyonlar aynı işlemleri defalarca teker teker yazmamak için kullandığımız yapılardır bir kod satirinin fonksiyon olup olmadiğini () ile anlayabiliriz clean code yazmak istiyorsak fonksiyonları kullanmamız gerekiyor

Deger Donduren ve Dondurmeyen Metotlar arasındaki farklar : 
public void SayilariTopla(int a, int b) 
{
Body…..
Cw(sayilarin toplami : a+b)….
}
 şeklinde yazılan bir fonksiyon geriye bir değer döndürmezler içindeki işlevleri yerine getirirler 



public T SayilariTopla(T a, T b) 
{
Body…..
return a+b; 
}
şeklinde yazılan bir fonksiyon geriye <T> türünden bir değer donduruler ve su sekilde kullanılabilir 
double Sonuc = SayilariTopla(4.55, 8,98) ile bir değişkende tutabiliriz bu sekilde


Metodun Parametreleri Nasıl Çalısır ? : Bir metodu yazarken, metodun içine parametre olarak ne tür bilgiler alacağını belirleriz 
-parametrelerin tipi , kac parametre alacaği gibi konfigürasyonlar yapilabilir 
