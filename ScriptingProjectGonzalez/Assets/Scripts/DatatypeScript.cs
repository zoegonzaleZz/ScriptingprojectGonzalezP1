using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(1, 8, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
