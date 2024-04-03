using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace libVillageois
{
    public class Villageois
    {
        private bool _malade;

        private string _nom;

        private int _poids;

        private int _dose;

        private Potion _maPotion;
   
        
        public Villageois(bool malade,string nom, int poids, int dose)
        {
            this._malade = malade;
            this._nom = nom;
            this._poids = poids;
            this._dose = dose;
            this._maPotion = new Potion(dose);

        }
        public Villageois(bool malade, string nom, int poids)
        {
            this._malade = malade;
            this._nom = nom;
            this._poids = poids;
            this._maPotion = new Potion(0);

        }
        public Villageois(string nom)
        {
            this._nom = nom;
            bool malade = false;
            this._maPotion = new Potion(0);
        }

        public override string ToString()
        {
            return "Le villageois se nomme "+this._nom+" peut soulever "+this._poids+" et est ";
        }
        
        public bool getMalade()
        {
            return _malade;
        }
        public string getNom()
        {
            return _nom;
        }
        public int getPoids()
        {
            return _poids;
        }
        public Potion getPotion() 
        {
            return _maPotion;
        }
       
        public int setPoids(int poids)
        { 
            _poids = poids;
            return poids; 
        }
        public int setDose(int dose)
        {
            dose = _maPotion.getDose();
            return dose;
        }

        public int poidsSouleve()
        {
            double dopage = _maPotion.ConsequencesDoses();
            double resultat = _poids*(1+  dopage)/ 5;

            return Convert.ToInt32(resultat);
        }
        public bool soulevememepoids(Villageois b)
        {
            bool flag = false;
            
            if (this._poids == b.getPoids())
            {
                 flag = true;
            }

            return flag;
           
        }
        public string plusFort(Villageois b)
        {
            string ret = "";
            if (this.soulevememepoids(b) == true)
                ret = "Les villageois soulevent le meme poids";

            if (b.poidsSouleve() > this._poids)
                ret = $"le villageois {b.getNom()} est plus fort que le villageois " + this.getNom();
            else
                ret = "le villlageois " + this.getNom() + " est plus fort que le villageois " + b.getNom();
            
            return ret;
        }
       
        

    }
}