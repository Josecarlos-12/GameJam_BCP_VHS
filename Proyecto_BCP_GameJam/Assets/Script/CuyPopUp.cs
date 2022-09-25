using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyPopUp : MonoBehaviour
{
    public GameObject prest, returCredi;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReturnPresta()
    {
        prest.SetActive(false);
        returCredi.SetActive(true);
    }

    public void Presta()
    {
        prest.SetActive(true);
        returCredi.SetActive(false);
    }
}
