using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private string nombre;
    private int vida;
    private int da�o;

    public static int score = 0;

    public Enemigo(string _nombre, int _vida, int _da�o)
    {
        nombre = _nombre;
        vida = _vida;
        da�o = _da�o;
    }

    public void RecibirDa�o(int da�oRecibido)
    {
        vida -= da�oRecibido;
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

