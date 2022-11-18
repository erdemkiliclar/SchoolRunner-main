using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _gemText;
    public static float gemCount;

    private void FixedUpdate()
    {
        _gemText.text = gemCount + "";

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gemCount++;
            _gemText.text = gemCount + "";
            Destroy(this.gameObject);
        }
    }
}
