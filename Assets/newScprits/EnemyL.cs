using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyL : MonoBehaviour
{

    private float B_Speed;

    public GameObject ef_obj;

    // Start is called before the first frame update
    void Start()
    {
        B_Speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(B_Speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Wall")
        {
            Destroy(gameObject, 0);
        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0);
        }

    }



}
