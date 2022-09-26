using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWork : MonoBehaviour
{
    public SelectionJobs selec;
    public Timer time;
    public GameObject timeComplete;

    public GameObject popUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        if (time.sema > 6)
        {
            selec.working = false;
            time.button.SetActive(false);
            time.buttonSaba.SetActive(false);
            timeComplete.SetActive(true);
            selec.sema = false;
        }
        else
        {
            popUp.SetActive(true);
        }
    }

    public void pop()
    {
        popUp.SetActive(false);
    }
}
