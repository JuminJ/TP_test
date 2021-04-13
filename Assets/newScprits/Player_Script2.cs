using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script2 : MonoBehaviour
{

    private float x_pos;
    private float y_pos;
    private float moving_speed;

    public float Speed;

    public GameObject BulletR;
    public GameObject BulletL;
    public GameObject BulletF;
    public GameObject BulletB;

    // Start is called before the first frame update
    void Start()
    {
        this.x_pos = 0.0f;
        this.y_pos = 0.0f;
        this.moving_speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Player_Ctrl();
        Shoot();
    }

    void Player_Ctrl()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * this.moving_speed * Time.smoothDeltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * this.moving_speed * Time.smoothDeltaTime, Space.World);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * this.moving_speed * Time.smoothDeltaTime, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * this.moving_speed * Time.smoothDeltaTime, Space.World);


    }

    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            Instantiate(BulletF,
            new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(BulletL,
            new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(BulletB,
            new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(BulletR,
            new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }

    private void OnTriggerEnter(Collider col)
    {


        if(col.gameObject.tag == "Enemy2")
        {
            Destroy(col.gameObject,0);
            Debug.Log("Damaged!!");
        }
    }
}
