using UnityEngine;

public class Animacion : MonoBehaviour
{
    public Animator animator;
    public GameObject botonAnimacion;
    public GameObject botonDetenerAnimacion;
    public GameObject botonParaboloideActivo;
    public GameObject botonParaboloideInactivo;
    public bool animacion = false;
    public bool paraboloide = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        botonDetenerAnimacion.SetActive(false);
        botonParaboloideActivo.SetActive(false);
    }

    void Update()
    {
        animator.SetBool("ParaboloideActivo", paraboloide);
        animator.SetBool("Animacion", animacion);
    }

    public void ActivarAnimacion()
    {
        animacion = true;
        botonAnimacion.SetActive(false);
        botonDetenerAnimacion.SetActive(true);
    }

    public void DesactivarAnimacion()
    {
        animacion = false;
        botonAnimacion.SetActive(true);
        botonDetenerAnimacion.SetActive(false);
    }

    public void Interseccion()
    {
        paraboloide = true;
        botonParaboloideActivo.SetActive(true);
        botonParaboloideInactivo.SetActive(false);
    }

    public void NoInterseccion()
    {
        paraboloide = false;
        botonParaboloideActivo.SetActive(false);
        botonParaboloideInactivo.SetActive(true);
    }
}