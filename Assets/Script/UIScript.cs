using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    //Vars
    private static int numNO2 = 0;
    private static int numN2O4 = 0;
    public TextMeshProUGUI particleNum;
    public GameObject particleGen;


    

    public void SliderController(Slider slider)
    {
        List<GameObject> list = GetComponent<ParticleGeneration>().GetNO2List();
        if (slider.value > numNO2)
        {
            particleGen.GetComponent<ParticleGeneration>().InstantiateGameObjects(GameObject.Find("NO2"), 25);
            numNO2++;
        }
        if (slider.value < numNO2)
        {
            
            particleGen.GetComponent<ParticleGeneration>().DestroyGameObjects("NO2");
            numNO2--;
        }
    }

    public void CreateButton()
    {
        particleGen.GetComponent<ParticleGeneration>().InstantiateGameObjects(GameObject.Find("NO2"), 25);
        numNO2 += 25;
    }

    public void DestroyButton()
    {
        if (numNO2 != 0)
        {
            particleGen.GetComponent<ParticleGeneration>().DestroyGameObjects("NO2");
            numNO2--;
        }
        
        Debug.Log(numNO2);
    }

    public void N02Count()
    {
        //Moved molecule object outside of chamber for count to reflect the molecules inside chamber
        particleNum.text = "NO2: " + numNO2;
    }

    public void N2O4Count()
    {
        //Moved molecule object outside of chamber for count to reflect the molecules inside chamber
        particleNum.text = "N2O4: " + numN2O4;
    }
}
