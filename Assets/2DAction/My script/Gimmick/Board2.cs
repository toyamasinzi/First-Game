using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board2 : MonoBehaviour
{
    [SerializeField] GameObject _board;
    [SerializeField] GameObject _dstoroy;
    [SerializeField] AudioClip se;
    private AudioSource Adi;

    private bool _Audio = false;
    private bool _played = true;
    void Start()
    {
        Adi = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (_Audio && _played)
        {
            Adi.PlayOneShot(se);
            _played = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_board.GetComponent<Board>()._key == true)
        {
            _dstoroy.SetActive(false);
            _Audio = true;
        }
    }

}