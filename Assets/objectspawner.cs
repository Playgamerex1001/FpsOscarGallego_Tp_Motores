using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectspawner : MonoBehaviour
{

    public GameObject objprefab;
    public Vector3 spawnPosition;
    public float Bforce;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject BalaClone = Instantiate(objprefab, transform.position, transform.rotation);
            Rigidbody balaRigidBody = BalaClone.GetComponent<Rigidbody>();
            balaRigidBody.velocity = transform.forward * Bforce;
        }
    }
}
