using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message_Changer : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI CherriesText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Message 1")
        {
            CherriesText.text = ("Well done on collecting all those cogs.");
        }
        if (collision.gameObject.name == "Message 2")
        {
            CherriesText.text = ("We are going a little slow though.");
        }
        if (collision.gameObject.name == "Message 3")
        {
            CherriesText.text = ("Maybe we could stop and you could get us some more?");
        }
    }
}
