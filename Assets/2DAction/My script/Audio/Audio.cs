using UnityEngine;

public class Audio : MonoBehaviour
{
   [SerializeField] AudioClip se;
    private AudioSource Adi;

    void Start()
    {
        Adi = GetComponent<AudioSource>();
    }

    // �Ԃ��������ɉ���炷
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Adi.PlayOneShot(se);
    }
}