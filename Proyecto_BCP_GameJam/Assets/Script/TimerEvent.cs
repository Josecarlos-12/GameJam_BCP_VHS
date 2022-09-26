using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimerEvent : MonoBehaviour
{

    public Timer time;
    public GameObject popUp;
    public GameObject[] EventsDays;
    public int popNum;

    public GameObject backGround;
    public int count;
    public ProbalityNumbers prob;

    public Text comentario;
    public Text perdida;
    public GameObject boxComentary;
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
        boxComentary.SetActive(true);
        StartCoroutine(Diaries());
    }

    public IEnumerator Diaries()
    {
        yield return new WaitForSeconds(30f);
        time.countTues = 0;
        time.counThurs = 0;
        time.countSatur = 0;
    }

    #region EventosDiarios
    public void DayOne1()
    {
        
        MetodoDiario();
        prob.healf -= 2;
        comentario.text = "El GallinoTen te cayó pesado";
        perdida.text = "-2 de salud";
        StartCoroutine(NexOption());
    }
    public void DayOne2()
    {
        MetodoDiario();
        prob.money -= 36;
        prob.healf += 3;
        comentario.text = "Tu estómago y tu salud te lo agradece";
        perdida.text = "-36 de Dinero / +3 Salud";
        StartCoroutine(NexOption());
    }

    public void DayTwo1()
    {
        MetodoDiario();
        prob.money += 460;
        prob.stress += 6;
        comentario.text = "Te llevaste el dinero pero ahora llevas un cargo de conciencia";
        perdida.text = "+460 Dinero / +8 Estrés";
        StartCoroutine(NexOption());
    }
    public void DayTwo2()
    {
        MetodoDiario();
        prob.money += 150;
        prob.stress -= 6; 
        comentario.text = "El señor muy agradecido te dio un premio por tu honestidad";
        perdida.text = "+150 Dinero / - 6 Estrés";
        StartCoroutine(NexOption());
    }

    public void DayThree()
    {
        MetodoDiario();
        prob.money -= 250;
        prob.stress -= 12;
        comentario.text = "La pasas bien, pero gastas mucho dinero";
        perdida.text = "+150 Dinero / - 6 Estrés";
        StartCoroutine(NexOption());
    }
    public void DayThree2()
    {
        MetodoDiario();
        prob.stress += 5;
        comentario.text = "No haces gastos innecesarios, pero el no salir te estresa";
        perdida.text = "+5 Estrés";
        StartCoroutine(NexOption());
    }

    public void DayFour1()
    {
        MetodoDiario();
        prob.healf -=4;
        prob.healf -= 2;
        comentario.text = "Pasaste el reto y tus amigos se asombraron, pero lastimosamente vomitaste hasta tu cerebro";
        perdida.text = "- 4 Salud / - 2 Estrés";
        StartCoroutine(NexOption());
    }
    public void DayFour2()
    {
        MetodoDiario();
        prob.stress += 9;
        comentario.text = "Tus amigos se burlaron de ti y te pusiste depresivo";
        perdida.text = "+9 Estrés";
        StartCoroutine(NexOption());
    }
    #endregion






    public void EventOne()
    {
        boxComentary.SetActive(true);
        popUp.SetActive(false);
        time.ultimate = false;
        prob.healf -= 40;
        prob.stress += 20;
        comentario.text = "No se llevó tus pertenencias, lo malo es que ahora tienes una hemorragia leve";
        perdida.text = "– 40 Salud / + 20 Estrés"; 
        StartCoroutine(NexOption());
    }

    public void EventTwo()
    {
        boxComentary.SetActive(true);
        popUp.SetActive(false);
        time.ultimate = false;
        prob.money -= 400;
        prob.stress -= 15;
        comentario.text = "Estás ileso, aunque te quitaron tu cartera";
        perdida.text = "- 400 Dinero / + 15 Estrés";
        StartCoroutine(NexOption());
    }

    public IEnumerator NexOption()
    {
        yield return new WaitForSeconds(3);
        boxComentary.SetActive(false);
    }
}
