using System;
using UnityEngine;

public class Hazzard  : MonoBehaviour
{
    //timer for tracking how often player is damaged
    private float timer = 0.99f;
    
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            if (timer >= 1f)
            {
                // Insert code to apply damage
                //other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
                Debug.Log("If this were finished, you would be DEAD");
                timer = 0f; // Reset timer for the next second
            }
            /*PlayerInteract pInteract = other.GetComponent<PlayerInteract>();
            if (pInteract != null)
            {
                //Insert the code to damage/kill the player here
                //Destroy(gameObject);
                Debug.Log("If this were finished, you would be DEAD");
            }*/
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        // Resets timer when player leaves so damage doesn't "carry over"
        if (other.CompareTag("Player"))
        {
            timer = 0.99f;
        }
    }
}
