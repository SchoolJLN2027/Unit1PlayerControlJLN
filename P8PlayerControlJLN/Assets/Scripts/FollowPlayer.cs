using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 5, -7);

    // late updates happens after the update method
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
