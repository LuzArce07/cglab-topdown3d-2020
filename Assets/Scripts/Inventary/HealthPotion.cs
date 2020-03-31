using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class HealthPotion : MonoBehaviour
{
    [SerializeField]
    Potion potion;

    private void OnTriggerEnter(Collider other)
    {
        potion.Drink();
        Debug.Log("Healt Restored");
        Destroy(gameObject);
    }

}
