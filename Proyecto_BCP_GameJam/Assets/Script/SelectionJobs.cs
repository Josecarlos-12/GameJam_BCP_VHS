using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectionJobs : MonoBehaviour
{
    public GameObject workComplete, WorkMediun, ButtonComplete, buttonMediun;
    public GameObject work, change, cachuelo,  retu;
    public float money;

    public bool desactive;
    public bool working;
    public bool sema;
    public Timer timer;
    public void Complete()
    {
        ButtonsWoks();
    }

    public void Mediun()
    {
        ButtonsWoks();
    }

    public void ButtonsWoks()
    {
        working = true;
           desactive = true;
        //workComplete.SetActive(false);
        //WorkMediun.SetActive(false);
        change.SetActive(true);
        work.SetActive(true);
        cachuelo.SetActive(true);
        retu.SetActive(true);
        sema = true;
        timer.sema = 0;
    }

    public void Administration()
    {
        money = 525;
        ButtonsWoks();
        ButtonComplete.SetActive(false);
    }

    public void Dev()
    {
        money = 450;
        ButtonsWoks();
        ButtonComplete.SetActive(false);
    }

    public void Mozo()
    {
        money = 275;
        ButtonsWoks();
        ButtonComplete.SetActive(false);
    }

    public void Cajero()
    {
        money = 187;
        ButtonsWoks();
        buttonMediun.SetActive(false);
    }

    public void DiseñoGraf()
    {
        money = 250;
        ButtonsWoks();
        buttonMediun.SetActive(false);
    }
}
