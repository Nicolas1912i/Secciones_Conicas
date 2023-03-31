using UnityEngine;

public class ControlModulo : MonoBehaviour
{
    public GameObject botonInformacionModulo;
    public GameObject botonInformacionModuloNO;
    public GameObject textoInformativoModulo;

    void Start()
    {
        botonInformacionModuloNO.SetActive(false);
        textoInformativoModulo.SetActive(false);
    }

    void Update()
    {
        
    }
    public void AparecerInformacionModulo()
    {
        textoInformativoModulo.SetActive(true);
        botonInformacionModulo.SetActive(false);
        botonInformacionModuloNO.SetActive(true);
    }

    public void DesaparecerInformacionModulo()
    {
        textoInformativoModulo.SetActive(false);
        botonInformacionModulo.SetActive(true);
        botonInformacionModuloNO.SetActive(false);
    }
}