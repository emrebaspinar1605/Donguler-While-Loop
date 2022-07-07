// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Bir sayı giriniz: ");
int sayi=int.Parse(Console.ReadLine());
int sayac=1;
int top=0;
while (sayac<=sayi)
{
    top+=sayac;
    sayac ++;
}
System.Console.WriteLine(top/sayi);
char character='a';
while (character <= 'z')
{
    Console.Write(character);
    character++;
}

System.Console.WriteLine("***** Foreach *****");
string[] cars={"Bmw","Ford","Toyota","Nissan"};
foreach (var car in cars)
{
    System.Console.WriteLine(car);
}
