using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject scripter;

    // Start is called before the first frame update
    void Start()
    {
        scripter = GameObject.FindGameObjectWithTag("Scripter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scripter.GetComponent<RoomManager>().ChangeRoom();
    }
}
