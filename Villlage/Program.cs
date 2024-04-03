using libVillage;
using libVillageois;

Villageois a, b;
string rep;

a = new Villageois(true, "Panoramix", 16);
b = new Villageois("Abraracourcix");

b.setPoids(26);
Console.WriteLine(a.ToString());
a.setDose(3);
Console.WriteLine($"{a.getNom()} prend {a.getPotion().getDose()} doses");
Console.WriteLine("Après les doses " + a.plusFort(b));
Console.WriteLine($"{a.getNom()} soulève {a.poidsSouleve()} poids");
Console.WriteLine($"{b.getNom()} soulève {b.poidsSouleve()} poids");

Village villageGaulois = new Village(500, "glenBret", "petit village");
villageGaulois.AjouterVillageois(a);
villageGaulois.AjouterVillageois(b);
villageGaulois.AjouterNewVillageois(true, "glenBret", 20, 3);
Console.WriteLine(villageGaulois.GetVillageois("Panoramix").ToString());
Console.WriteLine($"Il y'a {villageGaulois.GetHabitants().Count} habitants dans le village de {villageGaulois.GetNom()}");

