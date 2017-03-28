using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour {

    public float distance = 1.0f;

	void Update () {

        Ray ray = new Ray(transform.position, transform.forward);
        Color color = Color.green;
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
            color = Color.red;
            Debug.Log(hit.collider.tag);
        }
        Debug.DrawRay(ray.origin, ray.direction * distance, color);
	}
}
