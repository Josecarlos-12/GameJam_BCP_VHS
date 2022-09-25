using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimerEvent : MonoBehaviour
{

    public Timer time;
    public GameObject popUp;
    public GameObject[] EventsDays;
    public int popNum;

    public GameObject backGround;
    public int count;
    void Update()
    {

        if (time.ultimate)
        {
            popUp.SetActive(true);
        }

        if(time.Tuesday || time.Thursday || time.Saturday)
        {
            count++;
            if (count == 1)
            {
                time.enabled = false;
                popNum = Random.Range(0, EventsDays.Length);
                EventsDays[popNum].SetActive(true);
                backGround.SetActive(true);
            }
            
        }
    }

    public void MetodoDiario()
    {
        time.countTues = 5;
        time.counThurs = 5;
        time.countSatur = 5;
        count = 0;
        backGround.SetActive(false);
        EventsDays[popNum].SetActive(false);
        time.enabled = true;
        popUp.SetActive(false);
        time.Tuesday = false;
        time.Thursday = false;
        time.Saturday = false;
        StartCoroutine(Diaries());
    }

    public IEnumerator Diaries()
    {
        yield return new WaitForSeconds(2f);
        time.countTues = 0;
        time.counThurs = 0;
        time.countSatur = 0;
    }

    #region EventosDiarios
    public void DayOne1()
    {
        MetodoDiario();
    }
    public void DayOne2()
    {
        MetodoDiario();
    }

    public void DayTwo1()
    {
        MetodoDiario();
    }
    public void DayTwo2()
    {
        MetodoDiario();
    }

    public void DayThree()
    {
        MetodoDiario();
    }
    public void DayThree2()
    {
        MetodoDiario();
    }

    public void DayFour1()
    {
        MetodoDiario();
    }
    public void DayFour2()
    {
        MetodoDiario();
    }
    #endregion






    public void EventOne()
    {
        popUp.SetActive(false);
        time.ultimate = false;
    }

    public void EventTwo()
    {
        popUp.SetActive(false);
        time.ultimate = false;
    }
}
