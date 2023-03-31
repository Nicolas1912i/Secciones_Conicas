using UnityEngine.UI;
using UnityEngine;

public class ControlMaestro : MonoBehaviour
{
    public GameObject solidoParaModificar; 
    public GameObject botonesSolido; 
    public GameObject slidersSolido;
    public GameObject objetoSliderUniforme; 
    public GameObject objetoSliderEscalaX; 
    public GameObject objetoSliderEscalaY; 
    public GameObject objetoSliderEscalaZ;
    public GameObject objetoSliderRotacionX; 
    public GameObject objetoSliderRotacionY; 
    public GameObject objetoSliderRotacionZ;
    public Slider sliderEscalaUniforme; 
    public Slider sliderEscalaX; 
    public Slider sliderEscalaY; 
    public Slider sliderEscalaZ;
    public Slider sliderRotacionX; 
    public Slider sliderRotacionY; 
    public Slider sliderRotacionZ;
    /*public GameObject botonHabilitarEscalas; 
    public GameObject botonHabilitarRotaciones;
    public GameObject botonInhabilitarEscalas; 
    public GameObject botonInhabilitarRotaciones;
    public GameObject botonResetearEscala; 
    public GameObject botonResetearRotacion;*/
    public float escalaX; 
    public float escalaY; 
    public float escalaZ; 
    public float rotacionX; 
    public float rotacionY; 
    public float rotacionZ;
    public bool escalaDisponible = false; 
    public bool rotacionDisponible = false;
    public bool resetearEscala = false; 
    public bool resetearRotacion = false;
    private bool panelTransformacionesYN;
    public float escalaXInicial; 
    public float escalaYInicial; 
    public float escalaZInicial;
    public float rotacionXInicial;
    public float rotacionYInicial; 
    public float rotacionZInicial;
    public GameObject objetoTextoEscalaX;
    public GameObject objetoTextoEscalaY;
    public GameObject objetoTextoEscalaZ;
    public GameObject objetoTextoRotacionX;
    public GameObject objetoTextoRotacionY;
    public GameObject objetoTextoRotacionZ;
    Text textoEscalaX;
    Text textoEscalaY;
    Text textoEscalaZ;
    Text textoRotacionX;
    Text textoRotacionY;
    Text textoRotacionZ;
    public GameObject panelTransformaciones;

    void Start()
    {
        solidoParaModificar.SetActive(false);

        InicializarTexto();
        //SlidersEscalaInactivos();
        //SlidersRotacionInactivos();
        EscalarConSliders();
        RotarConSliders();
        ObtenerEscalas();
        ObtenerRotaciones();
    }

    private void EscalarConSliders()
    {
        sliderEscalaUniforme.onValueChanged.AddListener(EscalarUniformemente);
        sliderEscalaX.onValueChanged.AddListener(EscalarX);
        sliderEscalaY.onValueChanged.AddListener(EscalarY);
        sliderEscalaZ.onValueChanged.AddListener(EscalarZ);
    }

    private void RotarConSliders()
    {
        sliderRotacionX.onValueChanged.AddListener(RotarX);
        sliderRotacionY.onValueChanged.AddListener(RotarY);
        sliderRotacionZ.onValueChanged.AddListener(RotarZ);
    }

    public void PanelTransformacionY()
    {
        panelTransformacionesYN = true;
    }

    public void PanelTransformacionN()
    {
        panelTransformacionesYN = false;
    }

    private void EscalarUniformemente(float newEscalaUniforme)
    {
        escalaX = newEscalaUniforme;
        escalaY = newEscalaUniforme;
        escalaZ = newEscalaUniforme;
    }

    private void EscalarX(float newEscalaX)
    {
        escalaX = newEscalaX;
    }

    private void RotarX(float newRotacionX)
    {
        rotacionX = newRotacionX;
    }

    private void EscalarY(float newEscalaY)
    {
        escalaY = newEscalaY;
    }

    private void RotarY(float newRotacionY)
    {
        rotacionY = newRotacionY;
    }

    private void EscalarZ(float newEscalaZ)
    {
        escalaZ = newEscalaZ;
    }

    private void RotarZ(float newRotacionZ)
    {
        rotacionZ = newRotacionZ;
    }

    /*private void SlidersEscalaInactivos()
    {
        objetoSliderUniforme.SetActive(false);
        objetoSliderEscalaX.SetActive(false);
        objetoSliderEscalaY.SetActive(false);
        objetoSliderEscalaZ.SetActive(false);
    }

    private void SlidersRotacionInactivos()
    {
        objetoSliderRotacionX.SetActive(false);
        objetoSliderRotacionY.SetActive(false);
        objetoSliderRotacionZ.SetActive(false);
    }

    private void SlidersEscalaActivos()
    {
        objetoSliderUniforme.SetActive(true);
        objetoSliderEscalaX.SetActive(true);
        objetoSliderEscalaY.SetActive(true);
        objetoSliderEscalaZ.SetActive(true);
    }

    private void SlidersRotacionActivos()
    {
        objetoSliderRotacionX.SetActive(true);
        objetoSliderRotacionY.SetActive(true);
        objetoSliderRotacionZ.SetActive(true);
    }*/

    /*private void HabilitarSlidersTransformacion()
    {
        if(escalaDisponible == true)
        {
            SlidersEscalaActivos();
            botonHabilitarEscalas.SetActive(false);
            botonInhabilitarEscalas.SetActive(true);
            botonResetearEscala.SetActive(true);
        }
        else
        {
            SlidersEscalaInactivos();
            botonHabilitarEscalas.SetActive(true);
            botonInhabilitarEscalas.SetActive(false);
            botonResetearEscala.SetActive(false);
        }

        if (rotacionDisponible == true)
        {
            SlidersRotacionActivos();
            botonHabilitarRotaciones.SetActive(false);
            botonInhabilitarRotaciones.SetActive(true);
            botonResetearRotacion.SetActive(true);
        }
        else
        {
            SlidersRotacionInactivos();
            botonHabilitarRotaciones.SetActive(true);
            botonInhabilitarRotaciones.SetActive(false);
            botonResetearRotacion.SetActive(false);
        }
    }*/

    private void ActualizarTransformaciones()
    {
        solidoParaModificar.transform.localScale = new Vector3(escalaX, escalaY, escalaZ);
        solidoParaModificar.transform.localRotation = Quaternion.Euler(new Vector3(rotacionX, rotacionY, rotacionZ));
    }

    void Update()
    {
        EstablecerTexto();
        //HabilitarSlidersTransformacion();
        ActualizarTransformaciones();
        ReiniciarValores();

        if (panelTransformacionesYN == true)
        {
            panelTransformaciones.SetActive(true);
        }
        else
        {
            panelTransformaciones.SetActive(false);
        }
    }

    private void ReiniciarValores()
    {
        if (resetearEscala)
        {
            sliderEscalaUniforme.value = escalaXInicial;
            sliderEscalaX.value = escalaXInicial;
            sliderEscalaY.value = escalaYInicial;
            sliderEscalaZ.value = escalaZInicial;
            solidoParaModificar.transform.localScale = new Vector3(escalaXInicial, escalaYInicial, escalaZInicial);
        }
        if (resetearRotacion)
        {
            sliderRotacionX.value = rotacionXInicial;
            sliderRotacionY.value = rotacionYInicial;
            sliderRotacionZ.value = rotacionZInicial;
            solidoParaModificar.transform.localRotation = Quaternion.Euler(new Vector3(rotacionXInicial, rotacionYInicial, rotacionZInicial));
        }
    }

    public void HabilitarEscalas()
    {
        escalaDisponible = true;
    }

    public void HabilitarRotaciones()
    {
        rotacionDisponible = true;
    }

    public void InhabilitarEscalas()
    {
        escalaDisponible = false;
    }

    public void InhabilitarRotaciones()
    {
        rotacionDisponible = false;
    }

    public void ResetearEscalaBooleano()
    {
        resetearEscala = true;
    }

    public void ReEscalarBooleano()
    {
        resetearEscala = false;
    }

    public void ResetearRotacionBooleano()
    {
        resetearRotacion = true;
    }

    public void ReRotarBooleano()
    {
        resetearRotacion = false;
    }

    private void ObtenerEscalas()
    {
        escalaX = solidoParaModificar.transform.localScale.x;
        escalaY = solidoParaModificar.transform.localScale.y;
        escalaZ = solidoParaModificar.transform.localScale.z;
    }

    private void ObtenerRotaciones()
    {
        rotacionX = solidoParaModificar.transform.localRotation.x;
        rotacionY = solidoParaModificar.transform.localRotation.y;
        rotacionZ = solidoParaModificar.transform.localRotation.z;
    }

    public void ActivarSolido()
    {
        solidoParaModificar.SetActive(true);
    }

    public void DesactivarSolido()
    {
        solidoParaModificar.SetActive(false);
    }

    private void InicializarTexto()
    {
        textoEscalaX = objetoTextoEscalaX.GetComponent<Text>();
        textoEscalaY = objetoTextoEscalaY.GetComponent<Text>();
        textoEscalaZ = objetoTextoEscalaZ.GetComponent<Text>();
        textoRotacionX = objetoTextoRotacionX.GetComponent<Text>();
        textoRotacionY = objetoTextoRotacionY.GetComponent<Text>();
        textoRotacionZ = objetoTextoRotacionZ.GetComponent<Text>();
        objetoTextoEscalaX.SetActive(false);
        objetoTextoEscalaY.SetActive(false);
        objetoTextoEscalaZ.SetActive(false);
        objetoTextoRotacionX.SetActive(false);
        objetoTextoRotacionY.SetActive(false);
        objetoTextoRotacionZ.SetActive(false);
    }

    private void EstablecerTexto()
    {
        textoEscalaX.text = "Escala X = " + escalaX;
        textoEscalaY.text = "Escala Y = " + escalaY;
        textoEscalaZ.text = "Escala Z = " + escalaZ;
        textoRotacionX.text = "Rotacion X = " + rotacionX;
        textoRotacionY.text = "Rotacion Y = " + rotacionY;
        textoRotacionZ.text = "Rotacion Z = " + rotacionZ;
    }

    public void TextoActivo()
    {
        objetoTextoEscalaX.SetActive(true);
        objetoTextoEscalaY.SetActive(true);
        objetoTextoEscalaZ.SetActive(true);
        objetoTextoRotacionX.SetActive(true);
        objetoTextoRotacionY.SetActive(true);
        objetoTextoRotacionZ.SetActive(true);
    }

    public void TextoInactivo()
    {
        objetoTextoEscalaX.SetActive(false);
        objetoTextoEscalaY.SetActive(false);
        objetoTextoEscalaZ.SetActive(false);
        objetoTextoRotacionX.SetActive(false);
        objetoTextoRotacionY.SetActive(false);
        objetoTextoRotacionZ.SetActive(false);
    }
}