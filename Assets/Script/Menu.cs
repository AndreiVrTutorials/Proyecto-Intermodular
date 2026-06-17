using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pulsacionBotonValladolid()
    {
        SceneManager.LoadScene("MenuValladolid");

    }
    public void pulsacionBotonSalamanca()
    {
        SceneManager.LoadScene("MenuSalamanca");

    }
    public void pulsacionBotonVolverMenuInicial()
    {
        SceneManager.LoadScene("MenuInicial");
    }


    public void pulsacionBotonCatedralSalamanca()
    {
        SceneManager.LoadScene("CatedralSalamanca");
    }
    public void pulsacionBotonCatedralValladolid()
    {
        SceneManager.LoadScene("CatedralValladolid");
    }
    public void pulsacionBotonFachadasSalamanca()
    {
        SceneManager.LoadScene("FachadasSalamanca");
    }
    public void pulsacionBotonFachadasValladolid()
    {
        SceneManager.LoadScene("FachadasValladolid");
    }
    
    public void pulsacionBVolverMenuValladolid()
    {
        SceneManager.LoadScene("MenuValladolid");
    }

    public void pulsacionBVolverMenuSalamanca()
    {
        SceneManager.LoadScene("MenuSalamanca");
    }

    public void pulsacionBotonEspañol()
    {
        IdiomaManager.instancia.CambiarIdioma("ES");
    }

    public void pulsacionBotonIngles()
    {
        IdiomaManager.instancia.CambiarIdioma("EN");
    }
}
