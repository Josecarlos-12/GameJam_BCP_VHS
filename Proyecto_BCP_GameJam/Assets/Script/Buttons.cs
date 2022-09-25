using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    public GameObject character;
    public GameObject slides;
    public GameObject botones;

    public GameObject jobs;

    public GameObject timeComplet;
    public GameObject time, mediunComplet, cachuelos, retu;
    public GameObject buttonMT, buttonCa;
    public GameObject acti;

    public GameObject cuy, returCuy;
    public void Prota()
    {
        character.SetActive(true);
        slides.SetActive(false);
        botones.SetActive(false);
    }

    public void ReturnProta()
    {
        character.SetActive(false);
        slides.SetActive(true);
        botones.SetActive(true);
    }

    public void Jobs()
    {
        jobs.SetActive(true);
        slides.SetActive(false);
        botones.SetActive(false);
    }

    public void JobsReturn()
    {
        jobs.SetActive(false);
        slides.SetActive(true);
        botones.SetActive(true);
    }

    public void TimeComplete()
    {
        timeComplet.SetActive(true);
        time.SetActive(false);
        retu.SetActive(false);
        mediunComplet.SetActive(false);
        cachuelos.SetActive(false);
    }

    public void TimeCompleteReturn()
    {
        timeComplet.SetActive(false);
        time.SetActive(true);
        retu.SetActive(true);
        mediunComplet.SetActive(true);
        cachuelos.SetActive(true);
    }

    public void TimeMediun()
    {
        buttonMT.SetActive(true);
        time.SetActive(false);
        retu.SetActive(false);
        mediunComplet.SetActive(false);
        cachuelos.SetActive(false);
    }

    public void TimeMediunReturn()
    {
        buttonMT.SetActive(false);
        time.SetActive(true);
        retu.SetActive(true);
        mediunComplet.SetActive(true);
        cachuelos.SetActive(true);
    }

    public void Cachuelo()
    {
        buttonCa.SetActive(true);
        time.SetActive(false);
        retu.SetActive(false);
        mediunComplet.SetActive(false);
        cachuelos.SetActive(false);
    }

    public void CachueloReturn()
    {
        buttonCa.SetActive(false);
        time.SetActive(true);
        retu.SetActive(true);
        mediunComplet.SetActive(true);
        cachuelos.SetActive(true);
    }

    public void Activities()
    {
        acti.SetActive(true);
    }

    public void ReturActivities()
    {
        acti.SetActive(false);
    }

    public void Cuyo()
    {
        cuy.SetActive(true);
    }

    public void ReturnCuyo()
    {
        cuy.SetActive(false);
    }

}
