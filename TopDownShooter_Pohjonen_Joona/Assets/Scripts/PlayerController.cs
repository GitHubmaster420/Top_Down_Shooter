using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10;
    public float horizontalInput;
    public float bordersX = 20;


    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // Move sideways
        transform.Translate(Vector3.right * Time.deltaTime * Speed * horizontalInput);
        
        if(transform.position.x > bordersX)
        {
            transform.position = new Vector3(bordersX, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < -bordersX)
        {
            transform.position = new Vector3(-bordersX, transform.position.y, transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Shoot projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
