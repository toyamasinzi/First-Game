using UnityEngine;

public class AudioCollider : MonoBehaviour
{
    [SerializeField] AudioClip _Se;
    private AudioSource _As;
    void Start()
    {
        _As = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _As.PlayOneShot(_Se);
    }
}
