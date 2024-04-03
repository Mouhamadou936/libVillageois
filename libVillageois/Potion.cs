using libVillageois;
using System.Runtime.CompilerServices;

public class Potion
{
    private int _dose;

    public Potion(int dose)
    {
        this._dose = dose;
    }
    public int getDose()
    {
        return _dose;
    }

    public void ajouterDose(int nb_doses)
    {
        _dose += nb_doses;
    }

    public double ConsequencesDoses()
    {
        double min = 0;
    if (_dose > 5 && _dose != 0) 
        {
            min = .5;
        }
    else
        {
            min = .10;
        }

        return min;
    }
}
