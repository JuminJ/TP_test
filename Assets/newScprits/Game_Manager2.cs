using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager2 : MonoBehaviour
{

    private float duration;

    public GameObject E_obj;

    private float RandomX;
    // Start is called before the first frame update
    void Start()
    {
        duration = 0;
    }

    // Update is called once per frame
    void Update()
    {
        duration++;

        if((duration % 300) == 1)
        { 
            RandomX = Random.Range(-10.0f,10.0f);
            Instantiate(E_obj,new Vector3(RandomX, 0, 50),Quaternion.identity);
        }
        
    }


}
