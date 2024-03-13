using System.Runtime.CompilerServices;

namespace libVillageois
{
    public class Village
    {
        private bool _malade;

        private string _nom;

        private int _poids;
        
        public Village(bool malade,string nom, int poids)
        {
            this._malade = malade;
            this._nom = nom;
            this._poids = poids;
        }
        public Village(string nom)
        {
            this._nom = nom;
            bool malade = false;
        }

        public override string ToString()
        {
            return "Le villageois se nomme "+this._nom+" peut soulever "+this._poids+" et est "+this._malade;
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
        public int setPoids(int poids)
        { 
            _poids = poids;
            return poids; 
        }

        public int poidsSouleve()
        {
            int resultat = _poids / 5;

            return resultat;
        }
        public bool soulevememepoids(Village a)
        {
            
            if (this._poids == a.getPoids())
            {
                return true;
            }
            else return false; 
            
           
        }

    }
}