using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevels : MonoBehaviour
{


    public GameObject[] levels;
    public float zPos = 80;
    public bool create = true;
    public int lvlnum;


    // Update is called once per frame
    void Update() 
    {
        if (create == true)
        {
            create = false;
            StartCoroutine(GenerateLevel());
        }
    }

    IEnumerator GenerateLevel()
    {
        lvlnum = Random.Range(0, levels.Length);
        Instantiate(levels[lvlnum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 80;
        yield return new WaitForSeconds(2);  
        create = true;
    }
}
