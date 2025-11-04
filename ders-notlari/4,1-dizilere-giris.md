# **Ders 15 Notları: Dizilere Giriş**

Selam Dostlar! Bu derste, `not1, not2, not3` gibi çoklu değişkenler yaratma zahmetinden kurtulmayı öğrendik.

### **1. Dizi (Array) Nedir?**

Dizi, **aynı tipteki** (hepsi sayı, hepsi metin vb.) birden fazla veriyi, **tek bir değişken adı altında** saklamamızı sağlayan bir veri yapısıdır.

### **2. Dizi Tanımlama ve Boyut Belirleme**

Bir dizi tanımlamak için `tip[]` kullanırız ve `new` anahtar kelimesiyle ona bir boyut (kaç eleman tutacağı) veririz.

```csharp
// Sözdizimi: veriTipi[] diziAdi = new veriTipi[boyut];

// 5 eleman tutabilen, 'sayilar' adında bir tamsayı (int) dizisi
int[] sayilar = new int[5];

// 3 eleman tutabilen, 'isimler' adında bir metin (string) dizisi
string[] isimler = new string[3];
```

**Önemli:** Dizilerin boyutu oluşturulduktan sonra **değiştirilemez!**

### **3. Değer Atama ve Erişme: İNDEKS KURALI**

Dizilerdeki verilere erişmek için **indeks** (index) adı verilen sıra numaralarını kullanırız.

**ALTIN KURAL:** Programlamada indeksler (sıralama) **0'DAN BAŞLAR!**

- 5 elemanlı bir dizinin indeksleri: `0, 1, 2, 3, 4`
- 3 elemanlı bir dizinin indeksleri: `0, 1, 2`

**Değer Atama (Yazma):**

```csharp
int[] sayilar = new int[3];

sayilar[0] = 100; // 1. eleman (0. indeks)
sayilar[1] = 200; // 2. eleman (1. indeks)
sayilar[2] = 300; // 3. eleman (2. indeks)
```

**Değere Erişme (Okuma):**

```csharp
Console.WriteLine(sayilar[0]); // Çıktı: 100
Console.WriteLine(sayilar[1]); // Çıktı: 200
```

### **4. Tehlike: `IndexOutOfRangeException`**

Eğer dizinizin sınırları dışındaki bir indekse (bölmeye) erişmeye çalışırsanız programınız çöker

```csharp
int[] sayilar = new int[3]; // Geçerli indeksler: 0, 1, 2

// HATA! 3 numaralı bir indeks yok!
// sayilar[3] = 400;
```

### **5. Kısa Yoldan Tanımlama**

Eğer dizinin elemanlarını en başta biliyorsak, boyutu belirtmeden de tanımlayabiliriz:

```csharp
// C# bunun 3 elemanlı olduğunu otomatik anlar
string[] gunler = { "Pazartesi", "Salı", "Çarşamba" };

Console.WriteLine(gunler[1]); // Çıktı: Salı
```
