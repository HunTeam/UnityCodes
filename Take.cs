using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{

    public Camera cam;
    public GameObject cube;
    public GameObject cubeInHand;
    public float range = 50f;

    void Start()
    {
        cubeInHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(hit.collider.tag == "one")
                {
                    cube.SetActive(false);
                    cubeInHand.SetActive(true);
                }
            }
        }
    }
}
