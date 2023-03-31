using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    public GameObject colores;
    public GameObject bw;
    
    void Start()
    {
        colores.SetActive(true);
        bw.SetActive(false);
    }

    void Update()
    {

    }

    public void TargetsAColor()
    {
        bw.SetActive(false);
        colores.SetActive(true);
    }

    public void TargetsAMono()
    {
        colores.SetActive(false);
        bw.SetActive(true);
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Escaner()
    {
        SceneManager.LoadScene(1);
    }

    public void ActivarEsferoide()
    {
        SceneManager.LoadScene(4);
    }

    public void ActivarEsferoideColor()
    {
        SceneManager.LoadScene(13);
    }

    public void ActivarElipsoide()
    {
        SceneManager.LoadScene(5);
    }

    public void ActivarElipsoideColor()
    {
        SceneManager.LoadScene(12);
    }

    public void ActivarParaboloide()
    {
        SceneManager.LoadScene(6);
    }

    public void ActivarParaboloideColor()
    {
        SceneManager.LoadScene(16);
    }

    public void ActivarParaboloideHiper()
    {
        SceneManager.LoadScene(7);
    }

    public void ActivarParaboloideHiperColor()
    {
        SceneManager.LoadScene(17);
    }

    public void ActivarHiperboloideUnaHoja()
    {
        SceneManager.LoadScene(8);
    }

    public void ActivarHiperboloideUnaHojaColor()
    {
        SceneManager.LoadScene(14);
    }

    public void ActivarHiperboloideDosHojas()
    {
        SceneManager.LoadScene(9);
    }

    public void ActivarHiperboloideDosHojasColor()
    {
        SceneManager.LoadScene(15);
    }

    public void ActivarConoEliptico()
    {
        SceneManager.LoadScene(10);
    }

    public void ActivarConoElipticoColor()
    {
        SceneManager.LoadScene(11);
    }

    public void Video()
    {
        SceneManager.LoadScene(2);
    }

    public void Libreria()
    {
        SceneManager.LoadScene(3);
    }
}