using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minus20 : MonoBehaviour
{
    GameObject _bag;
    Vector3 scaleChange;

    private void Awake()
    {
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _bag.transform.localScale -= scaleChange;
            Destroy(this.gameObject);
        }
    }
}
