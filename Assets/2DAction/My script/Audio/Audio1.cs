using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio1 : MonoBehaviour
{
    [SerializeField] AudioClip _se;
    private AudioSource _Adi;

    // Start is called before the first frame update
    void Start()
    {
        _Adi = GetComponent<AudioSource>();
    }
    private void OnDisable()
    {
        _Adi.PlayOneShot(_se);
        Debug.Log("1111");
    }
}
