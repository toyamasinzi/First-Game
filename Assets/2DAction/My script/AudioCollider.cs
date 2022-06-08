using UnityEngine;

public class AudioCollider : MonoBehaviour
{
    [SerializeField] AudioClip Se;
    private AudioSource As;
    void Start()
    {
        As = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        As.PlayOneShot(Se);
    }
}
