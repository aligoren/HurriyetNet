Hürriyet gazetesinin geliştiricilere açmış olduğu developer platformu için .NET Wrapper'ı

### Not:

Kullanmadan önce Hurriyet Developer API Dokümanını Okumanızı Tavsiye Ederim:

[Hurriyet API Doc](https://developers.hurriyet.com.tr/docs/versions/1.0)

Sonuçlar Json.NET kütüphanesinde yer alan `JArray` ve `JObject` türünden değer döndürmektedir.

### Bağımlılıklar:

HurriyetNet kütüphanesi Json.NET kütüphanesini kullanmaktadır. NuGet kullanarak kurulum için:

```
Install-Package Newtonsoft.Json
```

# NuGet

[![NuGet Version](http://img.shields.io/nuget/v/HurriyetNet.svg?style=flat)](https://www.nuget.org/packages/HurriyetNet/)

`Install-Package HurriyetNet`

# Kullanım

Kütüphane projeye dahil edildikten sonra

```csharp
using HurriyetNet;
```

ile referans projeye dahil edilir.

API Key alındıktan sonra KEY ayarı yapılır

```csharp
HurriyetConf.ApiKey = "API_KEY_BURADA";
```

Ardından `Hurriyet` class'ı çağırılarak statik array ve methodlar için çağrı yapılır.

## Makaleler

### Tüm Makaleler

```csharp
Hurriyet.AllArticles
```

### Tek Makale ID'ye Göre

```csharp
Hurriyet.SingleArticle("HABER IDSI");
```


## Köşe Yazıları

### Tüm Köşe Yazıları

```csharp
Hurriyet.AllColumns
```

### Tek Köşe Yazısı ID'ye Göre

```csharp
Hurriyet.SingleColumn("KÖŞE YAZISI IDSI");
```


## Yazarlar

### Tüm Yazarlar

```csharp
Hurriyet.AllWriters
```

### Tek Yazar ID'ye Göre

```csharp
Hurriyet.SingleWriter("YAZAR IDSI");
```


## Fotoğraf Galerileri

### Tüm Fotoğraf Galerileri

```csharp
Hurriyet.AllPhotoGalleries
```

### Tek Fotoğraf Galerisi ID'ye Göre

```csharp
Hurriyet.SinglePhotoGallery("FOTOGRAF GALERI IDSI");
```


## Sayfalar

### Tüm Sayfalar

```csharp
Hurriyet.AllPages
```

### Tek Sayfa ID'ye Göre

```csharp
Hurriyet.SinglePage("SAYFA IDSI");
```


## Klasörler

### Tüm Klasörler

```csharp
Hurriyet.AllPaths
```

### Tekil Klasör ID'ye Göre

```csharp
Hurriyet.SinglePath("YOL IDSI");
```


## Tarih

RFC 1123 tipinde tarih dizisi döndürür. RFC 1123 için "ols.ietf.org/html/rfc1123" adresine bakınız.

```csharp
Hurriyet.GetDate
```
