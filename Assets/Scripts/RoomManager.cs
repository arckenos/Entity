using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    GameObject[] rooms;
    GameObject cam;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        rooms = GameObject.FindGameObjectsWithTag("Room");
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeRoom()
    {
        int random = Random.Range(0, rooms.Length);
        random = random == rooms.Length ? 0 : random;

        Vector3 playerPos = player.transform.localPosition;
        if (playerPos.x < -10)
            playerPos.x = 10;
        else if (playerPos.x > 10)
            playerPos.x = -10;

        if (playerPos.y < -5.5)
            playerPos.y = 6;
        else if (playerPos.y > 6)
            playerPos.y = -5;

        Vector3 pos = rooms[random].transform.position;
        pos.z = -1;
        
        player.transform.localPosition = playerPos;


        
        cam.transform.position = pos;

        Debug.Log(rooms[random]);
    }
}
