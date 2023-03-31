using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materiales : MonoBehaviour
{

    public GameObject solido;
    public GameObject botonEstandar;
    public GameObject botonDegradado;
    public Material standar;
    public Material degradado;
    public bool materialDegradado;
    public bool materialStandar;
    
    void Start()
    {
        solido.gameObject.GetComponent<MeshRenderer>().material = degradado;
        botonEstandar.SetActive(true);
        botonDegradado.SetActive(false);
    }

    void Update()
    {
        if (materialDegradado == true)
        {
            solido.gameObject.GetComponent<MeshRenderer>().material = degradado;
            botonDegradado.SetActive(false);
            botonEstandar.SetActive(true);
        }

        if (materialStandar == true)
        {
            solido.gameObject.GetComponent<MeshRenderer>().material = standar;
            botonEstandar.SetActive(false);
            botonDegradado.SetActive(true);
        }
    }

    public void CambiarADegradado()
    {
        materialDegradado = true;
    }

    public void CambiarAStandar()
    {
        materialStandar = true;
    }
}
