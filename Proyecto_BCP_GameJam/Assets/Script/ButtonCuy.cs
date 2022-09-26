using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCuy : MonoBehaviour
{
    public GameObject retur, credito, cuentaAhorro, SeguroF, buttonCredit, buttonSeguro, buttonSalud;
    public GameObject popUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonCredito()
    {
        buttonCredit.SetActive(true);
        retur.SetActive(false);
        credito.SetActive(false);
        cuentaAhorro.SetActive(false);
        SeguroF.SetActive(false);
    }

    public void ReturnCredito()
    {
        buttonCredit.SetActive(false);
        retur.SetActive(true);
        credito.SetActive(true);
        cuentaAhorro.SetActive(true);
        SeguroF.SetActive(true);
    }

    public void ButtonSeguro()
    {
        buttonSeguro.SetActive(true);
        retur.SetActive(false);
        credito.SetActive(false);
        cuentaAhorro.SetActive(false);
        SeguroF.SetActive(false);
    }

    public void ButtonSeguroFalse()
    {
        popUp.SetActive(true);
        retur.SetActive(false);
    }
    public void ReturnSefuroFalse()
    {
        popUp.SetActive(false);
        retur.SetActive(true);
    }

    public void ReturnSeguro()
    {
        buttonSeguro.SetActive(false);
        retur.SetActive(true);
        credito.SetActive(true);
        cuentaAhorro.SetActive(true);
        SeguroF.SetActive(true);
    }

    public void Salud()
    {
        buttonSalud.SetActive(true);
        buttonSeguro.SetActive(false);
    }

    public void ReturnSalud()
    {
        buttonSalud.SetActive(false);
        buttonSeguro.SetActive(true);
    }
}
