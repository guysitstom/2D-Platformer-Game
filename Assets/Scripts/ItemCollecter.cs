using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollecter : MonoBehaviour
{
    public static int Cogs = 0;
    [SerializeField] private TextMeshProUGUI CherriesText;
    [SerializeField] private AudioSource colectsound;
    private void Start()
    {
        Cogs = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            Cogs++;
            CherriesText.text = "Cogs: " + Cogs;
            colectsound.Play();
        }
    }
}
