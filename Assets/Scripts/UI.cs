using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject bottomPanel; 
    public GameObject menuBoton; 
    public GameObject sloganText;
    public GameObject unfoldablePanel; 
    public GameObject volverBoton;
    public GameObject sliders; 
    public GameObject botones;

    void Start()
    {
        InicializarComponentesUI();
    }

    void Update()
    {

    }

    public void InicializarComponentesUI()
    {
        unfoldablePanel.SetActive(false);
    }

    public void DesplegarPanel()
    {
        unfoldablePanel.SetActive(true);
        menuBoton.SetActive(false);
        sloganText.SetActive(false);
    }

    public void OcultarPanelDesplegado()
    {
        unfoldablePanel.SetActive(false);
        menuBoton.SetActive(true);
        sloganText.SetActive(true);
    }
}