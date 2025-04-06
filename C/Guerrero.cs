using UnityEngine;

public class Guerrero : Personaje
{
    private int ira;
    private int da�o; 

    #region Getter y Setter
    public int Ira
    {
        get => ira;
        set => ira = value >= 0 ? value : 0; 
    }

    public int Da�o
    {
        get => da�o;
        set => da�o = value >= 0 ? value : 0; 
    }
    #endregion

    #region Constructor
    public Guerrero(string _charName, string _description, int _vida, int _ira, int _da�o)
        : base(_charName, _description) 
    {
        ira = _ira; 
        da�o = _da�o;
        Vida = _vida;
    }
    #endregion

    #region M�todos
    public int CalcularDa�o()
    {
        if (Vida <= 50) 
        {
            return da�o * 2;  
        }
        return da�o;  
    }
    #endregion
}


