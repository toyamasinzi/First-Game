using UnityEngine;

public class Audio : MonoBehaviour
{
   [SerializeField] AudioClip se;
    private AudioSource Adi;

    void Start()
    {
        Adi = GetComponent<AudioSource>();
    }

    // ぶつかった時に音を鳴らす
    void OnCollisionEnter2D(Collision2D collision)
    {
        Adi.PlayOneShot(se); 
    }
}