using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public float maxTimer;
    public int days;
    public int sema;
    public string[] daysText;
    public string textAll;

    public bool ultimate;

    public bool Tuesday;
    public bool Thursday;
    public bool Saturday;

    public int countTues;
    public int counThurs;
    public int countSatur;
    public ProbalityNumbers probality;
    public int sabado;
    public GameObject button, buttonSaba;
    public SelectionJobs select;
    public int cuota;
    public Prestamo pres;
    public Text textDays;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textDays.text = $"Hoy es: {textAll}";
        if (cuota == 14)
        {
            Debug.Log("Oe paga :v");
            cuota = 0;
        }

        if (!ultimate)
        {
            timer = timer + Time.deltaTime;
        }
        
        if (timer >= maxTimer)
        {
            if (select.sema)
            {
                sema++;
            }
            if (pres.cuota)
            {
                cuota++;
            }
            
            days++;
            Debug.Log($"Hoy es {textAll}");
            timer = 0;
            probality.count = 0;
            probality.countPop = 0;
        }

        if (days == 0)
        {
            if (select.working)
            {
                buttonSaba.SetActive(false);
                button.SetActive(true);
            }            
            textAll = daysText[0];
        }
        if(days == 1)
        {
            textAll = daysText[1];
        }
        if (days == 2)
        {
            textAll = daysText[2];
            Debug.Log("2");
            countTues++;
            if (countTues == 1)
            {
                Tuesday = true;
            }

        }
        if (days == 3)
        {
            textAll = daysText[3]; 
           
        }
        if (days == 4)
        {
            textAll = daysText[4];
            counThurs++;
            if (counThurs == 1)
            {
                Thursday = true;
            }
        }
        if (days == 5)
        {
            if (select.working)
            {
                buttonSaba.SetActive(true);
                button.SetActive(false);
            }            
            textAll = daysText[5];
           
        }
        if (days == 6)
        {
            
            textAll = daysText[6];
        }
        if (days >= 7)
        {
            days = 0;
            ultimate = true;
        }
    }
}
