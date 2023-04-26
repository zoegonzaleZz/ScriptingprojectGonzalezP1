using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 2);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
