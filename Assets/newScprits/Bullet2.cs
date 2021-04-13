using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{

    private float B_Speed;

    public GameObject ef_obj;

    // Start is called before the first frame update
    void Start()
    {
        B_Speed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,B_Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy2")
        {
            Destroy(gameObject,0);
            Destroy(col.gameObject,0);
            Instantiate(ef_obj, new Vector3(transform.position.x, transform.position.y,transform.position.z
                ),Quaternion.identity);

        }

        if(col.gameObject.tag == "Wall")
        {
            Destroy(gameObject, 0);
        }
    }


    
}
