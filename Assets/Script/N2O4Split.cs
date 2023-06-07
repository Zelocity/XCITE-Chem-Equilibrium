using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class N2O4Split : MonoBehaviour
{

    public GameObject particleGen;
    float timer = 0f;
    private int listSize;
    private List<GameObject> currList = null;

    void Start()
    {

        listSize = 0;
        timer = 0f;
        currList = ParticleGeneration.N2O4List;
        //currList = particleGen.GetComponent<ParticleGeneration>().GetN2O4List();
    }
    // Start is called before the first frame update
    void Update()
    {

        
        listSize = currList.Count;
        timer += Time.deltaTime;

        if (timer > 5f && listSize > 0)
        {
            // Debug.Log("5 SECONDS PASSED. About to delete");
            //particleGen.GetComponent<ParticleGeneration>().DestroyGameObjects("N2O4");
            timer = 0f;
        }

        /*StartCoroutine(waiter());*/
    }

    // Update is called once per frame
/*    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        Object.Destroy(this.gameObject);
    }*/
}
