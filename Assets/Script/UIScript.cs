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
    public TextMeshProUGUI particleCountText;
    public GameObject particleGen;
    public int particleCreationNum;




    public void SliderController(Slider slider)
    {
        List<GameObject> list = GetComponent<ParticleGeneration>().GetNO2List();
        if (slider.value > numNO2)
        {
            particleGen.GetComponent<ParticleGeneration>().InstantiateGameObjects(GameObject.Find("NO2"), particleCreationNum);
            numNO2 += particleCreationNum;
        }
        if (slider.value < numNO2)
        {

            particleGen.GetComponent<ParticleGeneration>().DestroyGameObjects("NO2");
            numNO2--;
        }
    }

    public void CreateButton()
    {
        particleGen.GetComponent<ParticleGeneration>().InstantiateGameObjects(GameObject.Find("NO2"), particleCreationNum);
        numNO2 += particleCreationNum;
    }

    public void DestroyButton()
    {
        if (numNO2 != 0)
        {
            particleGen.GetComponent<ParticleGeneration>().DestroyGameObjects("NO2");
            numNO2--;
        }

        //Debug.Log(numNO2);
    }


    //Moved molecule object outside of chamber for count to reflect the molecules inside chamber
    public void N02Count() { particleCountText.text = "NO2: " + numNO2; }

    //Moved molecule object outside of chamber for count to reflect the molecules inside chamber
    public void N2O4Count() { particleCountText.text = "N2O4: " + numN2O4; }

    public void Molecule_Math(int NO2_num, int N2O4_num) { numNO2 += NO2_num; numN2O4 += N2O4_num;}
}
