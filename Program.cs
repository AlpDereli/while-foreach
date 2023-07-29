// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sayi: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sayac =1, toplam = 0;
while (sayac<=sayi)
{
    toplam+= sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);

char c ='a';
while (c < 'z')
{
    Console.WriteLine(c);
    c++;
}

string[] araba = {"BMV", "Ford", "Toyota", "Nissan"};
foreach(var ar in araba)
{
    Console.WriteLine(ar);
}

