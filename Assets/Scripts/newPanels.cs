using UnityEngine;

public class newPanels : MonoBehaviour
{

    public GameObject[] panelesOriginales;
    public GameObject[] panelesTrazasNuevos;
    public GameObject[] panelesTransformacionesEscalasNuevos;
    public GameObject[] panelesTransformacionesRotacionesNuevos;
    public GameObject[] panelesActivacion;
    public GameObject[] botonesTrazas;
    public GameObject[] botonesEscalas;
    public GameObject[] botonesRotaciones;
    public GameObject[] botonesActivacionPanel;

    void Start()
    {
        panelesTrazasNuevos[0].SetActive(false);
        panelesTrazasNuevos[1].SetActive(false);
        panelesTrazasNuevos[2].SetActive(false);
        panelesTransformacionesEscalasNuevos[0].SetActive(false);
        panelesTransformacionesEscalasNuevos[1].SetActive(false);
        panelesTransformacionesEscalasNuevos[2].SetActive(false);
        panelesTransformacionesEscalasNuevos[3].SetActive(false);
        panelesTransformacionesRotacionesNuevos[0].SetActive(false);
        panelesTransformacionesRotacionesNuevos[1].SetActive(false);
        panelesTransformacionesRotacionesNuevos[2].SetActive(false);
        panelesActivacion[0].SetActive(true);
        panelesActivacion[1].SetActive(false);
    }

    void Update()
    {
        
    }

    public void ActivarPanelBotonesEscala()
    {
        panelesActivacion[0].SetActive(true);
        botonesActivacionPanel[0].SetActive(false);
    }

    public void ActivarPanelBotonesRotacion()
    {
        panelesActivacion[1].SetActive(true);
        botonesActivacionPanel[1].SetActive(false);
    }

    public void DesactivarPanelBotonesEscala()
    {
        panelesActivacion[0].SetActive(false);
        botonesActivacionPanel[0].SetActive(true);
    }

    public void DesactivarPanelBotonesRotacion()
    {
        panelesActivacion[1].SetActive(false);
        botonesActivacionPanel[1].SetActive(true);
    }

    public void ActivarTraza1()
    {
        panelesTrazasNuevos[0].SetActive(true);
        botonesTrazas[0].SetActive(false);
    }

    public void DesactivarTraza1()
    {
        panelesTrazasNuevos[0].SetActive(false);
        botonesTrazas[0].SetActive(true);
    }

    public void ActivarTraza2()
    {
        panelesTrazasNuevos[1].SetActive(true);
        botonesTrazas[1].SetActive(false);
    }

    public void DesactivarTraza2()
    {
        panelesTrazasNuevos[1].SetActive(false);
        botonesTrazas[1].SetActive(true);
    }

    public void ActivarTraza3()
    {
        panelesTrazasNuevos[2].SetActive(true);
        botonesTrazas[2].SetActive(false);
    }

    public void DesactivarTraza3()
    {
        panelesTrazasNuevos[2].SetActive(false);
        botonesTrazas[2].SetActive(true);
    }

    public void ActivarEscalaUniforme()
    {
        panelesTransformacionesEscalasNuevos[0].SetActive(true);
        botonesEscalas[0].SetActive(false);
        panelesActivacion[0].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
    }

    public void ActivarEscalaX()
    {
        panelesTransformacionesEscalasNuevos[1].SetActive(true);
        botonesEscalas[1].SetActive(false);
        panelesActivacion[0].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
    }

    public void ActivarEscalaY()
    {
        panelesTransformacionesEscalasNuevos[2].SetActive(true);
        botonesEscalas[2].SetActive(false);
        panelesActivacion[0].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
    }

    public void ActivarEscalaZ()
    {
        panelesTransformacionesEscalasNuevos[3].SetActive(true);
        botonesEscalas[3].SetActive(false);
        panelesActivacion[0].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
    }

    public void DesactivarEscalaUniforme()
    {
        panelesTransformacionesEscalasNuevos[0].SetActive(false);
        botonesEscalas[0].SetActive(true);
        panelesActivacion[0].SetActive(true);
    }

    public void DesactivarEscalaX()
    {
        panelesTransformacionesEscalasNuevos[1].SetActive(false);
        botonesEscalas[1].SetActive(true);
        panelesActivacion[0].SetActive(true);
    }

    public void DesactivarEscalaY()
    {
        panelesTransformacionesEscalasNuevos[2].SetActive(false);
        botonesEscalas[2].SetActive(true);
        panelesActivacion[0].SetActive(true);
    }

    public void DesactivarEscalaZ()
    {
        panelesTransformacionesEscalasNuevos[3].SetActive(false);
        botonesEscalas[3].SetActive(true);
        panelesActivacion[0].SetActive(true);
    }

    public void ActivarRotacionX()
    {
        panelesTransformacionesRotacionesNuevos[0].SetActive(true);
        botonesRotaciones[0].SetActive(false);
        panelesActivacion[1].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
    }

    public void ActivarRotacionY()
    {
        panelesTransformacionesRotacionesNuevos[1].SetActive(true);
        botonesRotaciones[1].SetActive(false);
        panelesActivacion[1].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
    }

    public void ActivarRotacionZ()
    {
        panelesTransformacionesRotacionesNuevos[2].SetActive(true);
        botonesRotaciones[2].SetActive(false);
        panelesActivacion[1].SetActive(false);
        botonesActivacionPanel[1].SetActive(false);
        botonesActivacionPanel[0].SetActive(false);
    }

    public void DesactivarRotacionX()
    {
        panelesTransformacionesRotacionesNuevos[0].SetActive(false);
        botonesRotaciones[0].SetActive(true);
        panelesActivacion[1].SetActive(true);
        botonesActivacionPanel[1].SetActive(true);
        botonesActivacionPanel[0].SetActive(true);
    }

    public void DesactivarRotacionY()
    {
        panelesTransformacionesRotacionesNuevos[1].SetActive(false);
        botonesRotaciones[1].SetActive(true);
        panelesActivacion[1].SetActive(true);
        botonesActivacionPanel[1].SetActive(true);
        botonesActivacionPanel[0].SetActive(true);
    }

    public void DesactivarRotacionZ()
    {
        panelesTransformacionesRotacionesNuevos[2].SetActive(false);
        botonesRotaciones[2].SetActive(true);
        panelesActivacion[1].SetActive(true);
        botonesActivacionPanel[1].SetActive(true);
        botonesActivacionPanel[0].SetActive(true);
    }
}