using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBorders : MonoBehaviour
{
    private float topBound = 30;
    private float sideBound = 20;
    private float bottomBound = -0;
    public GameObject GameOverScreen;
    private Vector3 GameOverPos = new Vector3(0, 4, 15);

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            // If enemy gets past player
            Debug.Log("Game Over!");
            // Load GameOverScreen on top
            Instantiate(GameOverScreen, GameOverPos, GameOverScreen.transform.rotation);
            Destroy(gameObject);
        }
        if (transform.position.x * transform.position.x > sideBound * sideBound)
        {
            Destroy(gameObject);
        }
    }
}
