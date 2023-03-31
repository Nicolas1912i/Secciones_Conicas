using UnityEngine;

public class ControlMenu : MonoBehaviour
{

    public GameObject botonParaTargets;
    public GameObject botonParaLibreria;
    public GameObject botonParaVideo;
    public GameObject señalVideoATarget;
    public GameObject señalVideoALibreria;
    public GameObject señalTargetAVideo;
    public GameObject señalLibreriaAVideo;

    // Start is called before the first frame update
    void Start()
    {
        botonParaTargets.SetActive(false);
        botonParaLibreria.SetActive(false);
        señalLibreriaAVideo.SetActive(false);
        señalTargetAVideo.SetActive(false);
    }

    void Update()
    {
        if (botonParaTargets.activeSelf == true)
        {
            señalVideoATarget.SetActive(false);
            señalVideoALibreria.SetActive(false);
            señalTargetAVideo.SetActive(true);
            señalLibreriaAVideo.SetActive(false);
        }
        if (botonParaVideo.activeSelf == true)
        {
            señalVideoALibreria.SetActive(true);
            señalVideoATarget.SetActive(true);
            señalTargetAVideo.SetActive(false);
            señalLibreriaAVideo.SetActive(false);
        }
        if (botonParaLibreria.activeSelf == true)
        {
            señalVideoALibreria.SetActive(false);
            señalVideoATarget.SetActive(false);
            señalTargetAVideo.SetActive(false);
            señalLibreriaAVideo.SetActive(true);
        }
    }

    public void PasarAModoTarget()
    {
        botonParaTargets.SetActive(true);
        botonParaVideo.SetActive(false);
    }

    public void PasarAModoLibreria()
    {
        botonParaLibreria.SetActive(true);
        botonParaVideo.SetActive(false);
    }

    public void PasarAVideoDesdeTarget()
    {
        botonParaTargets.SetActive(false);
        botonParaVideo.SetActive(true);
    }

    public void PasarAVideoDesdeLibreria()
    {
        botonParaLibreria.SetActive(false);
        botonParaVideo.SetActive(true);
    }
}
