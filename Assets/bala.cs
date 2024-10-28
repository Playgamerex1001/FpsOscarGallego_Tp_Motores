using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{

    [SerializeField] public int damage = 25;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemigo"))
        {
            collision.gameObject.GetComponent<enemigo>().ReceiveDamageFromBala(damage);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
