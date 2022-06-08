using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichAudio : MonoBehaviour
{
    [SerializeField] AudioClip se;
    private AudioSource Adi;

    void Start()
    {
        Adi = GetComponent<AudioSource>();
    }

    // ぶつかった時に音を鳴らす
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Adi.PlayOneShot(se); 
    }
}