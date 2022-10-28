using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GetComponent<WaypointFollower>().enabled = true;
            collision.gameObject.transform.SetParent(transform);
            GameObject.Find ("Player").GetComponent<PlayerMovement>().enabled = false;
        }
    }

}
