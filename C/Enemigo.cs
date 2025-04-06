using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private string nombre;
    private int vida;
    private int daño;

    public static int score = 0;

    public Enemigo(string _nombre, int _vida, int _daño)
    {
        nombre = _nombre;
        vida = _vida;
        daño = _daño;
    }

    public void RecibirDaño(int dañoRecibido)
    {
        vida -= dañoRecibido;
        if (vida <= 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Destroy(gameObject); 
    }

    void OnDestroy()
    {
       
        score += 10;
        Debug.Log($"El enemigo ha muerto. Score aumentado a: {score}");
    }
}

