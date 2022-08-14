using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class litter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Litter";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
   
}
