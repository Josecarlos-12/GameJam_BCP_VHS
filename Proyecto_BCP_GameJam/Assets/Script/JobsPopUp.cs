using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobsPopUp : MonoBehaviour
{
    public GameObject admi, dev, moz, retur;
    public GameObject cajer, diseGra, returMt;
    public GameObject paseDog, tutor, returCa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturAdmi()
    {
        admi.SetActive(false);
        retur.SetActive(true);
    }

    public void Administration()
    {
        admi.SetActive(true);
        retur.SetActive(false);
    }

    public void ReturVDJ()
    {
        dev.SetActive(false);
        retur.SetActive(true);
    }

    public void VDJ()
    {
        dev.SetActive(true);
        retur.SetActive(false);
    }


    public void ReturMozo()
    {
        moz.SetActive(false);
        retur.SetActive(true);
    }

    public void Mozo()
    {
        moz.SetActive(true);
        retur.SetActive(false);
    }

    public void ReturCajero()
    {
        cajer.SetActive(false);
        returMt.SetActive(true);
    }

    public void Cajero()
    {
        cajer.SetActive(true);
        returMt.SetActive(false);
    }


    public void ReturDise()
    {
        diseGra.SetActive(false);
        returMt.SetActive(true);
    }

    public void DiseGra()
    {
        diseGra.SetActive(true);
        returMt.SetActive(false);
    }

    public void PaseaDog()
    {
        paseDog.SetActive(true);
        returCa.SetActive(false);
    }

    public void RetuPaseaDog()
    {
        paseDog.SetActive(false);
        returCa.SetActive(true);
    }

    public void Tutor()
    {
        tutor.SetActive(true);
        returCa.SetActive(false);
    }

    public void ReturTuto()
    {
        tutor.SetActive(false);
        returCa.SetActive(true);
    }
}
