using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCam : MonoBehaviour
{
    public GameObject player;
    public GameObject MainCam;
    public GameObject Driver;
    public GameObject Rear;

    Vector3 offset = new Vector3(0, 5, 0);

    // late updates happens after the update method
    void Update()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            MainCam.SetActive(false);
            Driver.SetActive(false);
            Rear.SetActive(true);
        }
    }
}
