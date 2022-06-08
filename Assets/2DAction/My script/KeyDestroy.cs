using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDestroy : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player2 _player)) 
        {
            Destroy(this.gameObject);
        }
    }
}
