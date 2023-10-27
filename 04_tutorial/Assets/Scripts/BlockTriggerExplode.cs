using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTriggerExplode : MonoBehaviour
{
    // Start is called before the first frame update
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space clicked");
            this.GetComponent<Animator>().Play("Explode");
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("space clicked");
            this.GetComponent<Animator>().Play("Implode");
        }
    }
}
