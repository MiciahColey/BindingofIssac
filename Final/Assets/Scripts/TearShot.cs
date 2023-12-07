using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearShot : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 2;
    public Vector3 velocity;

    public IssacMovement player;

    public GameObject heom;
    

    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 3);
        Debug.Log("Shot is Gone");
    }

    // Update is called once per frame
    void Update()
    {

        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            for (int i = 0; i < 5; i++)
            {
                Quaternion direction =  Quaternion.Euler( transform.rotation.x, Random.Range(0,361),transform.rotation.z);
                GameObject go = Instantiate(heom, transform.position, direction);


            }




            Destroy(other.gameObject);
            Destroy(gameObject);
         

        }
        Debug.Log("Enemy hit by Tear");
    }


}
