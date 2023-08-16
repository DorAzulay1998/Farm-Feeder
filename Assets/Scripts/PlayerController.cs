using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    
    public float horiznotalInput;
    public float verticalInput;
    public float speed = 10f;
    public GameObject projectilePrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horiznotalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horiznotalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        ShootFood();
    }

    void ShootFood()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
