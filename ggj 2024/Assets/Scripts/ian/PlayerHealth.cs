using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int Health = 1 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("collided");
        if (collision.gameObject.tag == "Enemy")// checks for tag
        {
            Health -= 1;  
        }
    }
}
