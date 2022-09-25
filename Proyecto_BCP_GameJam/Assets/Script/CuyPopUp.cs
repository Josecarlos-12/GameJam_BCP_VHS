using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyPopUp : MonoBehaviour
{
    public GameObject prest, pagar, returCredi, salud, tajeta, auxilio, seguro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReturnPresta()
    {
        prest.SetActive(false);
        returCredi.SetActive(true);
    }

    public void Presta()
    {
        prest.SetActive(true);
        returCredi.SetActive(false);
    }

    public void Pagar()
    {
        pagar.SetActive(true);
        returCredi.SetActive(false);
    }

    public void ReturnPagar()
    {
        pagar.SetActive(false);
        returCredi.SetActive(true);
    }

    
    public void ReturnSalud()
    {
        salud.SetActive(false);
        returCredi.SetActive(true);
    }

    public void Salud()
    {
        salud.SetActive(true);
        returCredi.SetActive(false);
    }

    public void Tarjeta()
    {
        tajeta.SetActive(true);
        returCredi.SetActive(false);
    }

    public void ReturnTarjeta()
    {
        tajeta.SetActive(false);
        returCredi.SetActive(true);
    }

    public void Auxilio()
    {
        auxilio.SetActive(true);
        returCredi.SetActive(false);
    }
    public void ReturAuxilio()
    {
        auxilio.SetActive(false);
        returCredi.SetActive(true);
    }

    public void Seguro()
    {
        seguro.SetActive(true);
        returCredi.SetActive (false);
    }

    public void ReturnSeguro()
    {
        seguro.SetActive(false);
        returCredi.SetActive(true);
    }
}
