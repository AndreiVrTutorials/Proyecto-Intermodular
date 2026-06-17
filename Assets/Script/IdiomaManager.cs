using UnityEngine;

public class IdiomaManager : MonoBehaviour
{
    public static IdiomaManager instancia;
    public string idiomaActual = "ES";

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);

            idiomaActual = PlayerPrefs.GetString("IDIOMA", "ES");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CambiarIdioma(string nuevoIdioma)
{
    idiomaActual = nuevoIdioma;
    PlayerPrefs.SetString("IDIOMA", nuevoIdioma);
    PlayerPrefs.Save();

    TraducirTexto[] todosLosTextos = FindObjectsByType<TraducirTexto>(FindObjectsSortMode.None);
    foreach (TraducirTexto t in todosLosTextos)
    {
        t.ActualizarTexto();
    }
}
}