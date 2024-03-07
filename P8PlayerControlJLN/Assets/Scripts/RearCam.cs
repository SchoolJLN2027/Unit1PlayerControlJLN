using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearCam : MonoBehaviour
{
    public GameObject player;
    public GameObject Driver;
    public GameObject MainCam;
    public GameObject Rear;

    Vector3 offset = new Vector3(0, 5, 7);

    // late updates happens after the update method
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MainCam.SetActive(true);
            Driver.SetActive(false);
            Rear.SetActive(false);
        }
    }
}
