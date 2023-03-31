using UnityEngine;

public class DropDown : MonoBehaviour
{

    public GameObject[] imagenes;
    public GameObject[] botonesEcuaciones;
    public GameObject[] botonesEcuacionesNO;
    public GameObject[] panelesEcuaciones;

    void Start()
    {
        imagenes[0].SetActive(false);
        imagenes[1].SetActive(false);
        imagenes[2].SetActive(false);
        imagenes[3].SetActive(false);
        imagenes[4].SetActive(false);
        botonesEcuaciones[0].SetActive(false);
        botonesEcuaciones[1].SetActive(false);
        botonesEcuaciones[2].SetActive(false);
        botonesEcuaciones[3].SetActive(false);
        botonesEcuaciones[4].SetActive(false);
        botonesEcuacionesNO[0].SetActive(false);
        botonesEcuacionesNO[1].SetActive(false);
        botonesEcuacionesNO[2].SetActive(false);
        botonesEcuacionesNO[3].SetActive(false);
        botonesEcuacionesNO[4].SetActive(false);
        panelesEcuaciones[0].SetActive(false);
        panelesEcuaciones[1].SetActive(false);
        panelesEcuaciones[2].SetActive(false);
        panelesEcuaciones[3].SetActive(false);
        panelesEcuaciones[4].SetActive(false);
    }

    void Update()
    {
        while (panelesEcuaciones[0].activeSelf == true && (imagenes[1].activeSelf == true || imagenes[2].activeSelf == true || imagenes[3].activeSelf == true || imagenes[4].activeSelf == true))
        {
            panelesEcuaciones[0].SetActive(false);
            botonesEcuaciones[0].SetActive(false);
            botonesEcuacionesNO[0].SetActive(false);
        }

        while (panelesEcuaciones[1].activeSelf == true && (imagenes[0].activeSelf == true || imagenes[2].activeSelf == true || imagenes[3].activeSelf == true || imagenes[4].activeSelf == true))
        {
            panelesEcuaciones[1].SetActive(false);
            botonesEcuaciones[1].SetActive(false);
            botonesEcuacionesNO[1].SetActive(false);
        }

        while (panelesEcuaciones[2].activeSelf == true && (imagenes[0].activeSelf == true || imagenes[1].activeSelf == true || imagenes[3].activeSelf == true || imagenes[4].activeSelf == true))
        {
            panelesEcuaciones[2].SetActive(false);
            botonesEcuaciones[2].SetActive(false);
            botonesEcuacionesNO[2].SetActive(false);
        }

        while (panelesEcuaciones[3].activeSelf == true && (imagenes[0].activeSelf == true || imagenes[1].activeSelf == true || imagenes[2].activeSelf == true ||  imagenes[4].activeSelf == true))
        {
            panelesEcuaciones[3].SetActive(false);
            botonesEcuaciones[3].SetActive(false);
            botonesEcuacionesNO[3].SetActive(false);
        }

        while (panelesEcuaciones[4].activeSelf == true && (imagenes[0].activeSelf == true || imagenes[1].activeSelf == true || imagenes[2].activeSelf == true || imagenes[3].activeSelf == true))
        {
            panelesEcuaciones[4].SetActive(false);
            botonesEcuaciones[4].SetActive(false);
            botonesEcuacionesNO[4].SetActive(false);
        }
    }

    public void AparecerPlano0()
    {
        panelesEcuaciones[0].SetActive(true);
        botonesEcuaciones[0].SetActive(false);
        botonesEcuacionesNO[0].SetActive(true);
    }

    public void AparecerPlano1()
    {
        panelesEcuaciones[1].SetActive(true);
        botonesEcuaciones[1].SetActive(false);
        botonesEcuacionesNO[1].SetActive(true);
    }

    public void AparecerPlano2()
    {
        panelesEcuaciones[2].SetActive(true);
        botonesEcuaciones[2].SetActive(false);
        botonesEcuacionesNO[2].SetActive(true);
    }

    public void AparecerPlano3()
    {
        panelesEcuaciones[3].SetActive(true);
        botonesEcuaciones[3].SetActive(false);
        botonesEcuacionesNO[3].SetActive(true);
    }

    public void AparecerPlano4()
    {
        panelesEcuaciones[4].SetActive(true);
        botonesEcuaciones[4].SetActive(false);
        botonesEcuacionesNO[4].SetActive(true);
    }

    public void DesaparecerPlano0()
    {
        panelesEcuaciones[0].SetActive(false);
        botonesEcuaciones[0].SetActive(true);
        botonesEcuacionesNO[0].SetActive(false);
    }

    public void DesaparecerPlano1()
    {
        panelesEcuaciones[1].SetActive(false);
        botonesEcuaciones[1].SetActive(true);
        botonesEcuacionesNO[1].SetActive(false);
    }

    public void DesaparecerPlano2()
    {
        panelesEcuaciones[2].SetActive(false);
        botonesEcuaciones[2].SetActive(true);
        botonesEcuacionesNO[2].SetActive(false);
    }

    public void DesaparecerPlano3()
    {
        panelesEcuaciones[3].SetActive(false);
        botonesEcuaciones[3].SetActive(true);
        botonesEcuacionesNO[3].SetActive(false);
    }

    public void DesaparecerPlano4()
    {
        panelesEcuaciones[4].SetActive(false);
        botonesEcuaciones[4].SetActive(true);
        botonesEcuacionesNO[4].SetActive(false);
    }

    public void InputThings(int value)
    {
        if (value == 0)
        {
            imagenes[0].SetActive(false);
            imagenes[1].SetActive(false);
            imagenes[2].SetActive(false);
            imagenes[3].SetActive(false);
            imagenes[4].SetActive(false);
            botonesEcuaciones[0].SetActive(false);
            botonesEcuaciones[1].SetActive(false);
            botonesEcuaciones[2].SetActive(false);
            botonesEcuaciones[3].SetActive(false);
            botonesEcuaciones[4].SetActive(false);
        }
        if (value == 1)
        {
            imagenes[0].SetActive(true);
            imagenes[1].SetActive(false);
            imagenes[2].SetActive(false);
            imagenes[3].SetActive(false);
            imagenes[4].SetActive(false);
            botonesEcuaciones[0].SetActive(true);
            botonesEcuaciones[1].SetActive(false);
            botonesEcuaciones[2].SetActive(false);
            botonesEcuaciones[3].SetActive(false);
            botonesEcuaciones[4].SetActive(false);
        }
        if (value == 2)
        {
            imagenes[0].SetActive(false);
            imagenes[1].SetActive(true);
            imagenes[2].SetActive(false);
            imagenes[3].SetActive(false);
            imagenes[4].SetActive(false);
            botonesEcuaciones[0].SetActive(false);
            botonesEcuaciones[1].SetActive(true);
            botonesEcuaciones[2].SetActive(false);
            botonesEcuaciones[3].SetActive(false);
            botonesEcuaciones[4].SetActive(false);
        }
        if (value == 3)
        {
            imagenes[0].SetActive(false);
            imagenes[1].SetActive(false);
            imagenes[2].SetActive(true);
            imagenes[3].SetActive(false);
            imagenes[4].SetActive(false);
            botonesEcuaciones[0].SetActive(false);
            botonesEcuaciones[1].SetActive(false);
            botonesEcuaciones[2].SetActive(true);
            botonesEcuaciones[3].SetActive(false);
            botonesEcuaciones[4].SetActive(false);
        }
        if (value == 4)
        {
            imagenes[0].SetActive(false);
            imagenes[1].SetActive(false);
            imagenes[2].SetActive(false);
            imagenes[3].SetActive(true);
            imagenes[4].SetActive(false);
            botonesEcuaciones[0].SetActive(false);
            botonesEcuaciones[1].SetActive(false);
            botonesEcuaciones[2].SetActive(false);
            botonesEcuaciones[3].SetActive(true);
            botonesEcuaciones[4].SetActive(false);
        }
        if (value == 5)
        {
            imagenes[0].SetActive(false);
            imagenes[1].SetActive(false);
            imagenes[2].SetActive(false);
            imagenes[3].SetActive(false);
            imagenes[4].SetActive(true);
            botonesEcuaciones[0].SetActive(false);
            botonesEcuaciones[1].SetActive(false);
            botonesEcuaciones[2].SetActive(false);
            botonesEcuaciones[3].SetActive(false);
            botonesEcuaciones[4].SetActive(true);
        }
    }
}