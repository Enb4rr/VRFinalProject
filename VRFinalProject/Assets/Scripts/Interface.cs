using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    [SerializeField] Canvas onPicked, onFloor;

    private void Awake()
    {
        onPicked.gameObject.SetActive(false);
    }

    public void PickUp()
    {
        onFloor.gameObject.SetActive(false);
        onPicked.gameObject.SetActive(true);
    }

    public void Drop()
    {
        onPicked.gameObject.SetActive(false);
        onFloor.gameObject.SetActive(true);
    }
}
