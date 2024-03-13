using libVillageois;

Village a, b;
string rep;
a = new Village(true, "Panoramix", 16);
b = new Village("Abraracourcix");
Console.WriteLine(b.getPoids());
b.setPoids(26);
Console.WriteLine(a.ToString());
Console.WriteLine(a.getNom());
Console.WriteLine(a.getPoids());
Console.WriteLine(b.poidsSouleve()+"Kg");
Console.WriteLine(a.soulevememepoids(b));
if (a.poidsSouleve() > b.poidsSouleve())
{
    Console.WriteLine(a.getNom() + " soulève le plus de poids");
}
else
{
    Console.WriteLine(b.getNom() + " soulève le plus de poids");
}