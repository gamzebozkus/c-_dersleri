int time =DateTime.Now.Hour;


if (time>=6 && time<13)
{
        Console.WriteLine("Günaydın!");

}

else if (time<=18)
{
    Console.WriteLine("iyi günler!");
}

else
{
        Console.WriteLine("iyi geceler!");

}
string sonuc=time<=18 ? "iyi günler " : "iyi geceler";
    Console.WriteLine(sonuc);

sonuc=time>=6 && time<11 ? "günaydın" : time<=18 ? "iyi günler" : "iyi geceler";
Console.WriteLine(sonuc);




