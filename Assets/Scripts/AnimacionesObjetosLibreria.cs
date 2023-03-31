using UnityEngine;

public class AnimacionesObjetosLibreria : MonoBehaviour
{

    public Animator animator;
    public bool animacionRotacion;
    public GameObject[] botonesControl;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        botonesControl[1].SetActive(false);
    }

    void Update()
    {
        animator.SetBool("AnimacionRotacion", animacionRotacion);
    }

    public void IniciarAnim()
    {
        animacionRotacion = true;
        botonesControl[1].SetActive(true);
        botonesControl[0].SetActive(false);
    }

    public void DeternerAnim()
    {
        animacionRotacion = false;
        botonesControl[0].SetActive(true);
        botonesControl[1].SetActive(false);
    }
}