using System;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField, Range(1.1f, 2f)] private float jumpPowerToAdd;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInteract pInteract = other.GetComponent<PlayerInteract>();
            if (pInteract != null)
            {
                //makes you jump higher
                pInteract.AddJumpPower(jumpPowerToAdd);
                Debug.Log("Balloon Get!");
                //removes balloon after getting it
                Destroy(gameObject);
            }
        }
    }
}
