using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSwod : MonoBehaviour
{
    public Transform Swod;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Swod")
        {
            Swod.transform.position = new Vector3(3, 1, -5);
        }
    }

}
