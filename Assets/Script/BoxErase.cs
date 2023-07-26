using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxErase : MonoBehaviour
{
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Tooltip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionExit(Collision collision)
    {
        Box1.SetActive(false);
        Box2.SetActive(false);
        Destroy(Tooltip.gameObject);

        if (Box2 == false && Box1 == false)
        {
            Destroy(Box1.gameObject);
            Destroy(Box2.gameObject);
            
        }
        

    }
}
