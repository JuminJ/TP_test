using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,-speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Wall")
        {
            Destroy(gameObject, 0);
        }

        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0);
        }
    }
}
