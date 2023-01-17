using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other == null)
            {
                Debug.Log("Hit");
                return;
            }
            Debug.Log("Hit Something");
            if (other.transform.tag == "Player")
            {
                Destroy(other.gameObject, 0.05f);
                Destroy(this.gameObject);
            }
        }

    }
}
