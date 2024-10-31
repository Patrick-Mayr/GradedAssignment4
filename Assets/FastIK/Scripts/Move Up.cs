using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    GameObject bodyTarget;
    // Start is called before the first frame update
    void Start()
    {
        bodyTarget = GetComponent<GameObject>();
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 2);
    }
}
