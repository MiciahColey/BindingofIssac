using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IssacEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tear")
        {
            
            Debug.Log("Enemy has be killed");
        }
        if (other.gameObject.tag == "BrimeStone")
        {

            Destroy(other.gameObject);
            Destroy(gameObject);

            Debug.Log("Enemy has be killed");
        }

    }




}
