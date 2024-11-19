using berek2020;
using System.Text;
List<Dolgozo> Dolgozok = [];

using StreamReader sr = new(@"../../../src/berek2020.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{

    Dolgozok.Add(new(sr.ReadLine()));
}


Console.WriteLine($"1. feladat\n" +
    $"Dolgozó adatok száma: {Dolgozok.Count}\n");

Console.WriteLine($"2. feladat\n" +
    $"Bér átlag 2020: {Math.Round(Dolgozok.Average(d => d.Ber) / 1000,1)} ezer forint.\n");

Console.Write($"3.feladat\n" +
    $"Részleg neve: ");
string reszleg = Console.ReadLine();
if (Dolgozok.Select(d=> d.Reszleg).Contains(reszleg)) Console.WriteLine($"{Dolgozok.MaxBy(d=> d.Ber)}\n");
else Console.WriteLine("A megadott részleg nem létezik a cégnél!\n");

Console.WriteLine("4. feladat\n" +
    "Az egyes részlegeken dolgozók száma:");
var stat = Dolgozok.GroupBy(d => d.Reszleg).Select(d => new {Reszleg = d.Key, Letszam = d.Count()});
foreach (var item in stat)
{
    Console.WriteLine($"{item.Reszleg} - {item.Letszam}");
}

Console.ReadKey();