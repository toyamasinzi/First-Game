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
        //�v���C���[�P�ƃv���C���[�Q�̃|�W�V���������
        transform.position = ((player1.position + player2.position) / 2) + new Vector3(0, 0, -12.141f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ((player1.position + player2.position) / 2) + new Vector3(0, 0, -12.141f);
    }
}
