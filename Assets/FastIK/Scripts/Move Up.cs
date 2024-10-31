using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public GameObject player;
    public int speed;
    public Transform upPos;
    public Transform downPos;
    //GameObject bodyTarget;
    // Start is called before the first frame update
    void Start()
    {
        //bodyTarget = GetComponent<GameObject>();
    }



    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        player.transform.position = Vector3.Lerp(upPos.position, downPos.position, time);

    }
}
