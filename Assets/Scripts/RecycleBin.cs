using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBin : MonoBehaviour
{
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Metal")
        {
            Destroy(other.gameObject);
        }
        this.count += 1;
    }
    void OnCollisionEnter(Collision col)
    {
        
    }
}
