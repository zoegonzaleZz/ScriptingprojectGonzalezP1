using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;

    void Awake ()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();

    }
    // Start is called before the first frame update
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is" + anotherScript.playerScore);
        Debug.Log("The player has died" + yetAnotherScript.numberOfPlayerDeaths + "times");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
