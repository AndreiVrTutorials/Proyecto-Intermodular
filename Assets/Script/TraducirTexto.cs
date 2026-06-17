using TMPro;
using UnityEngine;

public class TraducirTexto : MonoBehaviour
{
    public string textoES;
    public string textoEN;
    private TextMeshProUGUI texto;

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        ActualizarTexto();
    }

    // Ahora es PUBLIC para que el IdiomaManager la vea
    public void ActualizarTexto()
    {
        // Añadimos una seguridad por si el componente no se ha asignado aún
        if (texto == null) texto = GetComponent<TextMeshProUGUI>();

        if (IdiomaManager.instancia.idiomaActual == "ES")
        {
            texto.text = textoES;
        }
        else
        {
            texto.text = textoEN;
        }
    }
}
