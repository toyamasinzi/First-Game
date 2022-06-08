using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform player1;
    [SerializeField] Transform player2;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤー１とプレイヤー２のポジションを取る
        transform.position = ((player1.position + player2.position) / 2) + new Vector3(0, 0, -12.141f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ((player1.position + player2.position) / 2) + new Vector3(0, 0, -12.141f);
    }
}
