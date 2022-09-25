using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    public float maxTimer;
    public int days;
    public string[] daysText;
    public string textAll;

    public bool ultimate;

    public bool Tuesday;
    public bool Thursday;
    public bool Saturday;

    public int countTues;
    public int counThurs;
    public int countSatur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ultimate)
        {
            timer = timer + Time.deltaTime;
        }
        
        if (timer >= maxTimer)
        {
            
            days++;
            Debug.Log($"Hoy es {textAll}");
            timer = 0;
        }

        if (days == 0)
        {
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
