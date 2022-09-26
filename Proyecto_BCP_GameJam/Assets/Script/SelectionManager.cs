using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SelectionManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> genders = new List<Sprite>();
    private int selectedGender = 0;
    public GameObject playergender;

    public void NextOption()
    {
        selectedGender = selectedGender + 1;
        if (selectedGender == genders.Count)
        {
            selectedGender = 0;
        }
        sr.sprite = genders[selectedGender];
    }

    public void BackOption()
    {
        selectedGender = selectedGender - 1;
        if (selectedGender < 0)
        {
            selectedGender = genders.Count-1;
        }
        sr.sprite = genders[selectedGender];
    }

    public void PlayGame()
    {
        //PrefabUtility.SaveAsPrefabAsset(playergender,"Assets/selectedskin.prefab");
        SceneManager.LoadScene("MainGame");
        
    }

}
