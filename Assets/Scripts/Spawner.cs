using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject PinPrefab;
    public string button = "Fire1";

    void Update()
    {
        if(Input.GetButtonDown(button))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(PinPrefab, transform.position, transform.rotation);
    }
}
