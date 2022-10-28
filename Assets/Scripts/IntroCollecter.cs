using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroCollecter : MonoBehaviour
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
            CherriesText.text = "Collect all 4 Cogs in each stage to progress." ;
            colectsound.Play();
        }
    }
}
