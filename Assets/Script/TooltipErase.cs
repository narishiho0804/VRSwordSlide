using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipErase : MonoBehaviour
{
    
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
        Tooltip.SetActive(false);
    }
}
