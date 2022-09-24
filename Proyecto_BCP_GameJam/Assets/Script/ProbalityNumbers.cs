using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProbalityNumbers : MonoBehaviour
{
    public GameObject healfGame, stressGame; 
    public Image barHealf, barStreest;
    public ProbalityNumbers probality;

    public float maxMoney;
    public float maxHealf;
    public float maxStress;

    public float money;
    [Range(0f, 100)]
    public float healf;
    [Range(0f,100)]
    public float stress;

    public int indexMoney;
    public int indexHealf;
    public int indexStress;

    public string moneyText;
    public string healfText;
    public string stressText;

    public Text text;
    public Text HText;
    public Text SText;

    public GameObject[] textGame;
    public int indexGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healf <= maxHealf)
        {

        }
        barHealf.fillAmount = healf/maxHealf;
        barStreest.fillAmount=stress/maxStress;
        HText.text = healf.ToString("0");
        SText.text= stress.ToString("0");
    }

    public void TextEstadistic()
    {
        /*indexMoney=Random.Range(0,money.Length);
        moneyText = money[indexMoney].ToString();


        indexHealf =Random.Range(0,healf.Length);
        healfText = healf[indexHealf].ToString();

        indexStress=Random.Range(0,stress.Length);
        stressText = stress[indexStress].ToString();

        text.text=$"Dinero: {moneyText}." +
            $"Salud: {healfText}." + 
            $"Estres: {stressText}.";*/
        healfGame.SetActive(true);
        stressGame.SetActive(true) ;
        indexGame=Random.Range(0,textGame.Length);
        textGame[indexGame].gameObject.SetActive(true);

        if (indexGame == 0)
        {
            money = 650;
            healf = 55;
            stress = 26;
        }
        if (indexGame == 1)
        {
            money = 370;
            healf = 68;
            stress = 18;
        }
        if(indexGame == 2)
        {
            money = 160;
            healf = 79;
            stress = 6;
        }
    }
}
