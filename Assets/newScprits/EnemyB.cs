using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : MonoBehaviour
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
        transform.Translate(0, 0, B_Speed * Time.deltaTime);
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
