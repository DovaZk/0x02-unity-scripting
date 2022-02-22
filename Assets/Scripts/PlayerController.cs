using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardForce = 2000f;
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float PlayerSpeed = 500f;
    private int score = 0;
    public int health = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Fixed-update is called once physics refresh
    void FixedUpdate()
    {
        // ADD a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * PlayerSpeed, 0, 0);
        }
         if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * PlayerSpeed, 0, 0);
        }
         if ( Input.GetKey("w") )
        {
            rb.AddForce(0, 0, sidewaysForce * PlayerSpeed);
        }
         if ( Input.GetKey("s") )
        {
            rb.AddForce(0, 0, -sidewaysForce * PlayerSpeed);
        }
    }

    // Update is called once per frame
   // void Update()
    //{
//          if (this.health == 0)
   //     {
   //         Debug.Log("Game Over!");
//            RestartGame();
   //     }
   // }

    // function to restart the game
   // public void RestartGame()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}


    // Pick up a coin and destroy it when touch it
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            this.score += 1;
            string log = "Score:" + " " + score;
            Debug.Log(log);
            Object.Destroy(other.gameObject, 0.5f);
        }

        if (other.tag == "Trap")
        {
            this.health -= 1;
            string log = "Health:" + " " + health;
            Debug.Log(log);
        }

        if (other.tag == "Goal")
        {
            Debug.Log("You Win!");
        }
    }
}
