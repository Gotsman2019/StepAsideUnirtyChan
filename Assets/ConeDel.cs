using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeDel : MonoBehaviour
{
    private GameObject unitychan;
    private GameObject gameobject;
    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        
   }

    // Update is called once per frame
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        if (this.difference >= 0 )
        {
            Destroy(gameObject,1.0f);
        }
    }
}
