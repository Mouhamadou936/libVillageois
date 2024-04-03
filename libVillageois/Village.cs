namespace libVillage;

using global::libVillageois;
using libVillage;
using System.Runtime.CompilerServices;

public class Village
    {
        private int _superficie;

        private string description;

        private string name;

        private List<Villageois> mesHabitants;
    public Village(int superficie, string name,string description)
    {
        this.description = description;
        this.name = name;
        this._superficie = superficie; 
        this.mesHabitants = new List<Villageois>();
    }

    public void AjouterVillageois(Villageois b)
    {
        mesHabitants.Add(b);
    }
    public void AjouterNewVillageois(bool malade, string nom, int poids, int dose)
    {
        Villageois nouveauvillageois = new Villageois(malade, nom, poids, dose);
        mesHabitants.Add(nouveauvillageois);
    }
    public Villageois GetVillageois (string nom)
    {
        Villageois? v = null;
           foreach (Villageois b in mesHabitants)
           {
                if (b.getNom() == nom)
                {
                v = b;
                }
           }
        return v;
    }
    public List<Villageois> GetHabitants()
    {
        return mesHabitants;
    }

    public string GetNom()
    {
        return name;
    }
}

    
 
