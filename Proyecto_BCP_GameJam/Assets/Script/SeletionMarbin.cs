using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SeletionMarbin : MonoBehaviour
{
    public GameObject hombre, mujer;
    public GameObject textH, textM;
    public int count = 0;
    public TextMesh text;
    public GameObject canvas;
    public string nameH;
    public string nameM;
    public int index;
    public int indexPersonality;
    public int indexDistrity;
    public int indexFathers;

    public string[] namesMen;
    public string[] namesWoman;
    public int edad;

    public string[] personality;
    public string personali;

    public string[] distrity;
    public string where;

    [TextArea(4,4)]
    public string[] fhaters;
    public string who;

    public Text[] textAll;
    public Text family;

    public GameObject fatherOne, fatherTwo, fatherThree, fatherFour, fatherFive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 1)
        {
            textH.SetActive(true);
            textM.SetActive(false);
            mujer.SetActive(false);
            hombre.SetActive(true);
        }
        else if(count == 2)
        {
            textH.SetActive(false);
            textM.SetActive(true);
            mujer.SetActive(true);
            hombre.SetActive(false);
        }
    }


    public void ButtonMore()
    {
        count += 1;
        if (count >=3)
        {
            count = 1;
            
        }
    }

    public void ButtonLess()
    {
        count -= 1;
        if(count <= 0)
        {
            count = 2;
        }
    }

    public void Play()
    {
        if (count == 1)
        {
            edad = Random.Range(18, 35);
            index = Random.Range(0, namesMen.Length);
            nameH = namesMen[index];

            indexPersonality = Random.Range(0, personality.Length);
            personali = personality[indexPersonality];

            indexDistrity = Random.Range(0, distrity.Length);
            where = distrity[indexDistrity];

            indexFathers = Random.Range(0, fhaters.Length);
            who = fhaters[indexFathers];

            textAll[0].text = nameH;
            textAll[1].text = edad.ToString();
            textAll[2].text = where;
            textAll[3].text = personali;
            

            if (index == 0)
            {
                fatherOne.SetActive(true);
            }
            if (index == 1)
            {
                fatherTwo.SetActive(true);
            }
            if(index == 2)
            {
                fatherThree.SetActive(true);
            }
            if (index == 3)
            {
                fatherFour.SetActive(true);
            }
            if (index == 4)
            {
                fatherFive.SetActive(true);
            }

        }
        else if (count == 2)
        {
            edad = Random.Range(18, 35);
            index = Random.Range(0, namesWoman.Length);
            nameM=namesWoman[index];

             indexPersonality = Random.Range(0, personality.Length);
            personali=personality[indexPersonality];

            indexDistrity=Random.Range(0, distrity.Length);
            where=distrity[indexDistrity];

            indexFathers = Random.Range(0, fhaters.Length);
            who=fhaters[indexFathers];

            textAll[0].text = nameM;
            textAll[1].text = edad.ToString();
            textAll[2].text = where;
            textAll[3].text = personali;

            if (index == 0)
            {
                fatherFive.SetActive(true);
            }
            if (index == 1)
            {
                
                fatherThree.SetActive(true);
            }
            if (index == 2)
            {
                fatherFive.SetActive(true);
            }
            if (index == 3)
            {
                fatherTwo.SetActive(true);
            }
            if (index == 4)
            {
                fatherTwo.SetActive(true);
            }
        }
        canvas.SetActive(false);
    }
}
