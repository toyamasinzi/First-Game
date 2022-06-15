using UnityEngine;

public class Audio : MonoBehaviour
{
   [SerializeField] AudioClip se;
    private AudioSource Adi;

    void Start()
    {
        Adi = GetComponent<AudioSource>();
    }

    // ‚Ô‚Â‚©‚Á‚½Žž‚É‰¹‚ð–Â‚ç‚·
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Adi.PlayOneShot(se);
    }
}