using UnityEngine;
using UnityEngine.UI;

public class AnimacionRedondas : MonoBehaviour
{

	public Animator animator;
    public GameObject trazaZobj;
    public GameObject trazaYobj;
    public GameObject trazaXobj;
    public GameObject trazadoXCartelito;
    public GameObject trazadoYCartelito;
    public GameObject trazadoZCartelito;
    public GameObject botonIniciarAnimacionRotacion;
    public GameObject botonDetenerAnimacionRotacion;
	private bool animacionRotacion = false;
    private float trazaZ;
    private float trazaY;
    private float trazaX;
    public GameObject objetoTextoTrazaZ;
    public GameObject objetoTextoTrazaY;
    public GameObject objetoTextoTrazaX;
    Text trazaZtxt;
    Text trazaYtxt;
    Text trazaXtxt;
    public Slider trazaXSlider;
    public Slider trazaYSlider;
    public Slider trazaZSlider;

    void Start()
    {
        trazaXtxt = objetoTextoTrazaX.GetComponent<Text>();
        trazaYtxt = objetoTextoTrazaY.GetComponent<Text>();
        trazaZtxt = objetoTextoTrazaZ.GetComponent<Text>();
        trazaXobj.SetActive(false);
        trazaYobj.SetActive(false);
        trazaZobj.SetActive(false);
        trazaX = 1;
        trazaY = 1;
        trazaZ = 1;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("AnimacionRotacion", animacionRotacion);
        TextoSliders();
        Listeners();
        Trazas();
    }

    public void TargetPerdido()
    {
        TrazasInactivas();
    }

    private void TrazasInactivas()
    {
        trazaZ = 1;
        trazaX = 1;
        trazaY = 1;
    }

    private void Listeners()
    {
        trazaXSlider.onValueChanged.AddListener(TrazaX);
        trazaYSlider.onValueChanged.AddListener(TrazaY);
        trazaZSlider.onValueChanged.AddListener(TrazaZ);
    }

    private void Trazas()
    {
        if (trazaZ == 0)
        {
            trazaZobj.SetActive(true);
            trazadoZCartelito.SetActive(true);
        }
        else
        {
            trazaZobj.SetActive(false);
            trazadoZCartelito.SetActive(false);
        }

        if (trazaY == 0)
        {
            trazaYobj.SetActive(true);
            trazadoYCartelito.SetActive(true);
        }
        else
        {
            trazaYobj.SetActive(false);
            trazadoYCartelito.SetActive(false);
        }

        if (trazaX == 0)
        {
            trazaXobj.SetActive(true);
            trazadoXCartelito.SetActive(true);
        }
        else
        {
            trazaXobj.SetActive(false);
            trazadoXCartelito.SetActive(false);
        }
    }

    private void TrazaX(float newTrazaX)
    {
        trazaX = newTrazaX;
    }

    private void TrazaY(float newTrazaY)
    {
        trazaY = newTrazaY;
    }

    private void TrazaZ(float newTrazaZ)
    {
        trazaZ = newTrazaZ;
    }

    private void TextoSliders()
    {
        trazaXtxt.text = "X = " + trazaX;
        trazaYtxt.text = "Y = " + trazaY;
        trazaZtxt.text = "Z = " + trazaZ;
    }

    public void AnimacionRotacion()
    {
        animacionRotacion = true;
        botonDetenerAnimacionRotacion.SetActive(true);
        botonIniciarAnimacionRotacion.SetActive(false);
    }

    public void DetenerAnimacionRotacion()
    {
        animacionRotacion = false;
        botonDetenerAnimacionRotacion.SetActive(false);
        botonIniciarAnimacionRotacion.SetActive(true);
    }
}