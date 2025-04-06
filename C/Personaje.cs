using UnityEngine;

public class Personaje : MonoBehaviour
{
    #region Private
    private string charName;
    private string description;
    private int vida;
    #endregion

    #region Getters
    public string CharName => charName;
    public string Description => description;
    public int Vida
    {
        get => vida;
        set => vida = value >= 0 ? value : 0;
    }
    #endregion

    #region Constructors
    public Personaje()
    {
        charName = "null";
        description = "null";
        vida = 100;
    }

    public Personaje(string _charName, string _description)
    {
        charName = _charName;
        description = _description;
        vida = 100;
    }
    #endregion

    #region OnDestroy
    public void OnDestroy()
    {
        print("Me han destruido zhasbot!");
    }
    #endregion

    #region Methods de vida
    public void RecibirDaño(int dañoRecibido)
    {
        vida -= dañoRecibido;  
        if (vida <= 0)
        {
            vida = 0;  
            OnDestroy();  
            print($"{charName} ha muerto.");
        }
        else
        {
            print($"{charName} recibió {dañoRecibido} de daño. Vida restante: {vida}");
        }
    }
    #endregion
}


