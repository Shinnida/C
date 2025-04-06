using UnityEngine;


public class Mago : Personaje
{
    #region Private
    private int wisdom;
    private int mana;
    #endregion

    #region Getters/Setters
    public int Wisdom
    {
        get => wisdom;
        set => wisdom = value >= 0 ? value : 0; 
    }

    public int Mana
    {
        get => mana;
        set => mana = value >= 0 ? value : 0; 
    }
    #endregion

    #region Constructors
    public Mago(string _charName, string _description, int _wisdom, int _mana) : base(_charName, _description )
    {
        Wisdom = _wisdom;
        Mana = _mana;
    }

    public Mago(Mago copy) : base(copy.CharName, copy.Description)
    {
        Wisdom = copy.Wisdom;
        Mana = copy.Mana;
        Vida = copy.Vida; 
    }

    #endregion
}

