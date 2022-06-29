using UnityEngine;

public class DestroyAudio : MonoBehaviour
{
   // [SerializeField] AudioClip se;
    //private AudioSource Adi;
    [SerializeField] AudioClip _Clip;

    void Start()
    {
        GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
     AudioSource.PlayClipAtPoint(_Clip, transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     AudioSource.PlayClipAtPoint(_Clip, transform.position);
    }
}
