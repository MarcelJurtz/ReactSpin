using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinControl : MonoBehaviour {

    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rBody;

	void Update () {
        if (!isPinned)
        {
            rBody.MovePosition(rBody.position + Vector2.up * speed * Time.deltaTime);
        }
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);

            col.GetComponent<Rotator>().speed *= -1;

            isPinned = true;
        }
    }
}
