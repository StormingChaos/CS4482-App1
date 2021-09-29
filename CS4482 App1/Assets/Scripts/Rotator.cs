using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        Quaternion q = this.transform.rotation;
		float delta = rotationSpeed * Time.deltaTime;
		q *= Quaternion.Euler(0, delta, 0);
		this.transform.rotation = q;
    }
}
