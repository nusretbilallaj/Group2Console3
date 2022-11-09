using Group2Console3;

Console.WriteLine("Kolegji AAB");

//void SayHello(string emri)
//{
//    Console.WriteLine("----");
//    Console.WriteLine($"Hello {emri}");
//    Console.WriteLine("----");
//}
//SayHello("Blendi");

//int numri=10;
//bool kushti=false;
//string emri="Leron Berisha";

//SayHello(emri);
//emri="Blend Krasniqi";
//SayHello(emri);

//bool eshteRealizuar=true;

//if (eshteRealizuar==true)
//{
//    Console.WriteLine("Jemi ne rregull");
//}
//else
//{
//    Console.WriteLine("Nuk keni mjete te mjaftueshme!");
//}

//List<int> numrat=new List<int>();
//numrat.Add(1);
//numrat.Add(10);
//numrat.Add(100);

//foreach (int i in numrat)
//{
//    Console.WriteLine(i);
//}

//int numri=10;
Studenti studenti1 = new Studenti("Kastriot", "Gjoka", 21);
studenti1.SayHello();

Studenti studenti2 = new Studenti("Munker", "Tac", 21);
//studenti2.SayHello();

Profesori prof1 = new Profesori("Leron", "Berisha");
//prof1.SayHello();

List<Personi> lista = new List<Personi>();
lista.Add(studenti1);
lista.Add(studenti2);
lista.Add(prof1);

foreach (var per in lista)
{
    per.SayHello();
}

int Shuma(int numri1, int numri2)
{
    var rezultati = numri1 + numri2;
    return rezultati;
}

var rez=Shuma(10, 20);
Console.WriteLine(rez);
Console.WriteLine(Shuma(10,20));
