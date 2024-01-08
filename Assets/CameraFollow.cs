using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float y0ffset = 1f;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(player.position.x , player.position.y + y0ffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        //test
    }
}
