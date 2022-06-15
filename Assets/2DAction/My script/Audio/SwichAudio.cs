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

    // ‚Ô‚Â‚©‚Á‚½Žž‚É‰¹‚ð–Â‚ç‚·
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Adi.PlayOneShot(se); 
    }
}