using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class bala : MonoBehaviour
{
    public GameObject sangre;

    [SerializeField] public int damage = 25;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemigo"))
        {
            collision.gameObject.GetComponent<enemigo>().ReceiveDamageFromBala(damage);
            Destroy(gameObject);

            GameObject sangreClone = Instantiate (sangre, transform.position, transform.rotation);

            Destroy(sangreClone, 0.2f);
        }
        Destroy(gameObject);
    }
}
