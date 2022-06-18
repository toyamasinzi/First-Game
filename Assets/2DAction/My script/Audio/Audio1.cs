using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio1 : MonoBehaviour
{
    [SerializeField] AudioClip se;
    private AudioSource Adi;

    // Start is called before the first frame update
    void Start()
    {
        Adi = GetComponent<AudioSource>();
    }
    private void OnDisable()
    {
        Debug.Log("1111");
        Adi.PlayOneShot(se);
    }
}
