using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform _player1;
    [SerializeField] Transform _player2;

    void Update()
    {
        transform.position = ((_player1.position + _player2.position) / 2) + new Vector3(0, 0, -12.141f);
    }
}
