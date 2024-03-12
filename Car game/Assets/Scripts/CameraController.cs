using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smooth = 0.5f;
    public bool lookAtTarget = false;
    public float maxDistanceFromPlayer = 10f; // Maximum distance the camera can be from the player

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = target.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, newposition, smooth);

        // Ensure camera does not exceed the player
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > maxDistanceFromPlayer)
        {
            transform.position = target.position + (transform.position - target.position).normalized * maxDistanceFromPlayer;
        }

        if (lookAtTarget)
        {
            transform.LookAt(target);
        }
    }
}
