using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
 

    public static float pinSpeed = 20f;
    public Rigidbody2D rb;
    private bool isPinned;

    


    void Update()  // +FixedUpdate?
    {
        if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * pinSpeed * Time.deltaTime); // +FixedTime?

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            //GetComponent<Rotator>().speed *= -1; //Rotates in opposite direction
            //GetComponent<Rotator>().speed += 10f; //increases speed each time

            transform.SetParent(collision.transform);
            Score.PinCount++;
            isPinned = true;
        }
        else if(collision.tag == "Pin")
        {
            Lives.lives--;
        
        }

        if (Lives.lives < 1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
