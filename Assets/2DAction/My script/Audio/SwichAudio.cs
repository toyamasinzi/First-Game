using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichAudio : MonoBehaviour
{
    [SerializeField] AudioClip _se;
    private AudioSource _Adi;

    void Start()
    {
        _Adi = GetComponent<AudioSource>();
    }

    // �Ԃ��������ɉ���炷
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _Adi.PlayOneShot(_se); 
    }
}