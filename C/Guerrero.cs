using UnityEngine;

public class Guerrero : Personaje
{
    private int ira;
    private int daño; 

    #region Getter y Setter
    public int Ira
    {
        get => ira;
        set => ira = value >= 0 ? value : 0; 
    }

    public int Daño
    {
        get => daño;
        set => daño = value >= 0 ? value : 0; 
    }
    #endregion

    #region Constructor
    public Guerrero(string _charName, string _description, int _vida, int _ira, int _daño)
        : base(_charName, _description) 
    {
        ira = _ira; 
        daño = _daño;
        Vida = _vida;
    }
    #endregion

    #region Métodos
    public int CalcularDaño()
    {
        if (Vida <= 50) 
        {
            return daño * 2;  
        }
        return daño;  
    }
    #endregion
}


