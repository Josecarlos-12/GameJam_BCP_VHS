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

    public GameObject fatherOne, fatherTwo, fatherThree, fatherFour, fatherFive, fatherSix, fatherSeven;


    public ProbalityNumbers probality;

    public GameObject buttons,slide;

    public GameObject backGroun, backGround2;

    public GameObject imageHombre, ImageMujer;
    public Timer timer;


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
        timer.enabled = true;
        backGroun.SetActive(false);
        backGround2.SetActive(true);
        buttons.SetActive(true);
        slide.SetActive(true);
        probality.TextEstadistic();
        if (count == 1)
        {
            imageHombre.SetActive(true);
            ImageMujer.SetActive(false);
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
                fatherSix.SetActive(true);
            }

        }
        else if (count == 2)
        {
            imageHombre.SetActive(false);
            ImageMujer.SetActive(true);
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
                fatherSix.SetActive(true);
            }
            if (index == 1)
            {
                fatherThree.SetActive(true);
            }
            if (index == 2)
            {
                fatherFour.SetActive(true);
            }
            if (index == 3)
            {
                fatherSeven.SetActive(true);
            }
            if (index == 4)
            {
                fatherSeven.SetActive(true);
            }
        }
        canvas.SetActive(false);
    }
}
