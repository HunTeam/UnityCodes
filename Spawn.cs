using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawn : MonoBehaviour
{
    public GameObject Prefabs;
    Vector3 MoveDir2 = Vector3.zero;

    void Start()
    {
        PhotonNetwork.Instantiate(Prefabs.name, MoveDir2, Quaternion.identity);
    }
}
