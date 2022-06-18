using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform player1;
    [SerializeField] Transform player2;

    void Update()
    {
        transform.position = ((player1.position + player2.position) / 2) + new Vector3(0, 0, -12.141f);
    }
}
