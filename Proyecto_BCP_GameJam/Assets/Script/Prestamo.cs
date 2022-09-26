using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Prestamo : MonoBehaviour
{
    public int count;
    public ProbalityNumbers money;
    public GameObject popUp;
    public int mone;
    public int inicial;
    public bool cuota;
    public Timer time;
    public Text text;
    public GameObject pagar, retur;

    public bool quini, mil;
    public GameObject quinient, mili;
    // Start is called before the first frame update
    void Start()
    {
        
          
    }

    // Update is called once per frame
    void Update()
    {
        if (cuota)
        {
            string cuanto = mone.ToString();
            text.text = $"Debes S/.{cuanto} soles";
        }
    }

    public void Quini()
    {
        //count++;
        if(count == 0)
        {
            popUp.SetActive(true);
            mone = 540;
            quini = true;
            mil = false;
        }
        
    }

    public void Mil()
    {
        //count++;
        if (count == 0)
        {
            popUp.SetActive(true);
            mone = 1600;
            mil = true;
            quini = false;
        }
        
    }

    public void Tre()
    {
        //count++;
        if (count == 0)
        {
            popUp.SetActive(true);
            mone = 300 + 8;
        }
    }

    public void PopUp()
    {
        popUp.SetActive(false);
    }

    public void Cutoa2()
    {
        count++;
        popUp.SetActive(false);
        money.money = money.money += mone;
        cuota = true;
    }

    public void Pagar()
    {
        //pagar.SetActive(true);
        
        if (quini)
        {
            quinient.SetActive(true);
            retur.SetActive(false);
        }
        if (mil)
        {
            mili.SetActive(true);
            retur.SetActive(false);
        }
    }

    public void ReturnPagar()
    {
        
            quinient.SetActive(false);
            mili.SetActive(false);
            retur.SetActive(true);
        
    }


    public void PagarDiner()
    {
        if (money.money > mone)
        {
            quini = false;
            mil = false;
            count = 0;
            money.money -= mone;
            quinient.SetActive(false);
            mili.SetActive(false);
            retur.SetActive(true);
        }
    }
}
