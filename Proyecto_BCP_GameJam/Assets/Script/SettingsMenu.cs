using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
///
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidad;
    
    public AudioMixer audioMixer;
    
   void Start()
   {
    calidad =PlayerPrefs.GetInt("numeroDeCalidad",3);
    dropdown.value=calidad;
    ChangeQuality();
   }
   
   
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void ChangeQuality()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad",dropdown.value);
        calidad=dropdown.value;

    }

}
