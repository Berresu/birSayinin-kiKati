using System;
class HelloWorld {
  static void Main() {
    Console.Write("Bir Sayı Giriniz: ");
    string input = Console.ReadLine();
    int sayi = Convert.ToInt32(input);
    Console.WriteLine($"Girdiğiniz Sayının İki Katı: {sayi * 2}");
  }
}
