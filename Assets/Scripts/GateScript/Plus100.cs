using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus100 : MonoBehaviour
{
    GameObject _bag;
    Vector3 scaleChange;

    private void Awake()
    {
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.3f, 0.3f, 0.3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _bag.transform.localScale += scaleChange;
            Destroy(this.gameObject);
        }
    }
}
