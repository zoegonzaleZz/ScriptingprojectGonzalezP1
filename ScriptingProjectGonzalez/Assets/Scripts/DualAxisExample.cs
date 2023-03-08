using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public float hRange;
    public float yRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = y * yRange;

        transform.position = new Vector3(xPos, 0, yPos);
        Debug.Log(h.ToString ("F2"));
        Debug.Log(y.ToString ("F2"));

    }
}
