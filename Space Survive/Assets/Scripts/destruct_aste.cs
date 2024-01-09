using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct_aste : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
    }
}
