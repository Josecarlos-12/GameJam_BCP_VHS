using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOcio : MonoBehaviour
{
    public GameObject retur, ocio, rutine, visit, buttonOcio, buttonRutina;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ocio()
    {
        buttonOcio.SetActive(true);
        ocio.SetActive(false);
        retur.SetActive(false);
        rutine.SetActive(false);
        visit.SetActive(false);
    }
    
    public void ReturnOcio()
    {
        buttonOcio.SetActive(false);
        ocio.SetActive(true);
        retur.SetActive(true);
        rutine.SetActive(true);
        visit.SetActive(true);
    }

    public void Rutine()
    {
        buttonRutina.SetActive(true);
        ocio.SetActive(false);
        retur.SetActive(false);
        rutine.SetActive(false);
        visit.SetActive(false);
    }

    public void ReturRutine()
    {
        buttonRutina.SetActive(false);
        ocio.SetActive(true);
        retur.SetActive(true);
        rutine.SetActive(true);
        visit.SetActive(true);
    }

    public void Visit()
    {

    }
}
