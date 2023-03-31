using UnityEngine;
using UnityEngine.UI;

public class ControlRedondos : MonoBehaviour
{

    public GameObject solido;
    public GameObject panelTransformaciones;
    public GameObject panelTrazas;
    public GameObject panelInformacion;
    public GameObject formula;
    public GameObject formulaBotonAparecer;
    public GameObject formulaBotonDesaparecer;
    public GameObject aparecerPlanoBoton;
    public GameObject desaparecerPlanoBoton;
    public GameObject aparecerInformacionBoton;
    public GameObject desaparecerInformacionBoton;
    public Slider escalaUniformeSlider;
    public Slider escalaXSlider;
    public Slider escalaYSlider;
    public Slider escalaZSlider;
    public Slider rotacionXSlider;
    public Slider rotacionYSlider;
    public Slider rotacionZSlider;
    public float escalaX;
    public float escalaY;
    public float escalaZ;
    [Range(-1, 1)]public float rotacionX;
    [Range(-1, 1)]public float rotacionY;
    [Range(-1, 1)]public float rotacionZ;
    public float escalaXInicial;
    public float escalaYInicial;
    public float escalaZInicial;
    public float rotacionXInicial;
    public float rotacionYInicial;
    public float rotacionZInicial;
    public float posicionXInicial;
    public float posicionYInicial;
    public float posicionZInicial;
    private bool restablecerEscala;
    private bool restablecerRotacion;
    public GameObject objTextoEscalaX;
    public GameObject objTextoEscalaY;
    public GameObject objTextoEscalaZ;
    public GameObject objTextoRotacionX;
    public GameObject objTextoRotacionY;
    public GameObject objTextoRotacionZ;
    Text textoEscalaX;
    Text textoEscalaY;
    Text textoEscalaZ;
    Text textoRotacionX;
    Text textoRotacionY;
    Text textoRotacionZ;

    void Start()
    {
        ObtenerTransformaciones();
        EstablecerSliders();
        InicializarTexto();
        panelTransformaciones.SetActive(false);
        panelInformacion.SetActive(false);
        formulaBotonDesaparecer.SetActive(false);
        formula.SetActive(false);
    }

    void Update()
    {

        solido.transform.localPosition = new Vector3(posicionXInicial, posicionYInicial, posicionZInicial);

        EstablecerTextos();
        Transformar();
        RestablecerValores();

        if (panelTransformaciones.activeInHierarchy == true)
        {
            aparecerPlanoBoton.SetActive(false);
            desaparecerPlanoBoton.SetActive(true);
        }
        else
        {
            aparecerPlanoBoton.SetActive(true);
            desaparecerPlanoBoton.SetActive(false);
        }
    }

    private void InicializarTexto()
    {
        textoEscalaX = objTextoEscalaX.GetComponent<Text>();
        textoEscalaY = objTextoEscalaY.GetComponent<Text>();
        textoEscalaZ = objTextoEscalaZ.GetComponent<Text>();
        textoRotacionX = objTextoRotacionX.GetComponent<Text>();
        textoRotacionY = objTextoRotacionY.GetComponent<Text>();
        textoRotacionZ = objTextoRotacionZ.GetComponent<Text>();
    }

    private void EstablecerTextos()
    {
        textoEscalaX.text = "X = " + escalaX;
        textoEscalaY.text = "Y = " + escalaY;
        textoEscalaZ.text = "Z = " + escalaZ;
        textoRotacionX.text = "X = " + rotacionX;
        textoRotacionY.text = "Y = " + rotacionY;
        textoRotacionZ.text = "Z = " + rotacionZ;
    }

    private void EstablecerSliders()
    {
        escalaUniformeSlider.onValueChanged.AddListener(EscalarUniformemente);
        escalaXSlider.onValueChanged.AddListener(EscalarX);
        escalaYSlider.onValueChanged.AddListener(EscalarY);
        escalaZSlider.onValueChanged.AddListener(EscalarZ);
        rotacionXSlider.onValueChanged.AddListener(RotarX);
        rotacionYSlider.onValueChanged.AddListener(RotarY);
        rotacionZSlider.onValueChanged.AddListener(RotarZ);
    }

    private void ObtenerTransformaciones()
    {
        escalaX = solido.transform.localScale.x;
        escalaY = solido.transform.localScale.y;
        escalaZ = solido.transform.localScale.z;
        rotacionX = solido.transform.localRotation.x;
        rotacionY = solido.transform.localRotation.y;
        rotacionZ = solido.transform.localRotation.z;
    }

    private void EscalarUniformemente(float newEscalaGlobal)
    {
        escalaX = newEscalaGlobal;
        escalaY = newEscalaGlobal;
        escalaZ = newEscalaGlobal;
    }

    private void EscalarX(float newEscalaX)
    {
        escalaX = newEscalaX;
    }

    private void EscalarY(float newEscalaY)
    {
        escalaY = newEscalaY;
    }

    private void EscalarZ(float newEscalaZ)
    {
        escalaZ = newEscalaZ;
    }

    private void RotarX(float newRotacionX)
    {
        rotacionX = newRotacionX;
    }
    private void RotarY(float newRotacionY)
    {
        rotacionY = newRotacionY;
    }
    private void RotarZ(float newRotacionZ)
    {
        rotacionZ = newRotacionZ;
    }

    private void Transformar()
    {
        solido.transform.localScale = new Vector3(escalaX, escalaY, escalaZ);
        solido.transform.localRotation = Quaternion.Euler(new Vector3(rotacionX * 360, rotacionY * 360, rotacionZ * 360));
    }

    private void RestablecerValores()
    {
        if (restablecerEscala == true)
        {
            escalaUniformeSlider.value = escalaXInicial;
            escalaXSlider.value = escalaXInicial;
            escalaYSlider.value = escalaYInicial;
            escalaZSlider.value = escalaZInicial;
            solido.transform.localScale = new Vector3(escalaXInicial, escalaYInicial, escalaZInicial);
        }

        if (restablecerRotacion == true)
        {
            rotacionXSlider.value = rotacionXInicial;
            rotacionYSlider.value = rotacionYInicial;
            rotacionZSlider.value = rotacionZInicial;
            solido.transform.localRotation = Quaternion.Euler(new Vector3(rotacionXInicial, rotacionYInicial, rotacionZInicial));
        }
    }

    public void RestablecerEscala()
    {
        restablecerEscala = true;
    }

    public void RestablecerRotacion()
    {
        restablecerRotacion = true;
    }

    public void RotableDeNuevo()
    {
        restablecerRotacion = false;
    }

    public void EscalableDeNuevo()
    {
        restablecerEscala = false;
    }

    public void AparecerTransformaciones()
    {
        panelTransformaciones.SetActive(true);
        panelTrazas.SetActive(false);
    }

    public void DesaparecerTransformaciones()
    {
        panelTransformaciones.SetActive(false);
        panelTrazas.SetActive(true);
    }

    public void AparecerInformacion()
    {
        panelInformacion.SetActive(true);
        aparecerInformacionBoton.SetActive(false);
    }

    public void DesaparecerInformacion()
    {
        panelInformacion.SetActive(false);
        aparecerInformacionBoton.SetActive(true);
    }

    public void AparecerFormula()
    {
        formula.SetActive(true);
        formulaBotonAparecer.SetActive(false);
        formulaBotonDesaparecer.SetActive(true);
    }

    public void DesaparecerFormula()
    {
        formula.SetActive(false);
        formulaBotonAparecer.SetActive(true);
        formulaBotonDesaparecer.SetActive(false);
    }

    public void TargetDesaparecido()
    {
        panelTrazas.SetActive(false);
        solido.SetActive(false);
    }

    public void TargetEncontrado()
    {
        panelTrazas.SetActive(true);
        solido.SetActive(true);
    }
}