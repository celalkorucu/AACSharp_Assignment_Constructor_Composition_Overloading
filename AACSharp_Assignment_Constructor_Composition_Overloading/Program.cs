// See https://aka.ms/new-console-template for more information


using AACSharp_Assignment_Constructor_Composition_Overloading.Classes;
using Math = AACSharp_Assignment_Constructor_Composition_Overloading.Classes.Math;

Brand brand = new("BMW");
Window window = new(4);
Chassis chassis = new("Sedan");
Door door = new(4);
Model model = new ("X5");
Car car = new Car(brand,model,chassis,window,door,120000);




double result = Math.Calculate(2, 2, '*');
Console.WriteLine("Sonuç : "+result);

// Garbage Collector : C# ve .NET programlamada RAM'i otomatik olarak yöneten bir mekanizmadır.
// Kullanılmayan veya erişilemeyen objeleri RAM'den temizler.

// Generic yapılar değişken türünü belirtmedne kullanılabilen metod class veya arayüzlerdir.
// public class MyGenericClass<T> gibi
// Generic classlara ArrayList örnek olarka verilebilir

// Boxing işlemi değer tipini referans tipine  çevirme işlemidir.
// Unboxing işlemi ise bunun tam tersi olarak referans tipini değer tipine çevirme işidir.
// Bellek yönetimini olumlu veya olumsuz etkileyebilir.
 