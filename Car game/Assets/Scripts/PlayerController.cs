using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerController : MonoBehaviour
{
    [Header("REFERENCE")]
    public Transform m_TransToMove; // Assign the child transform representing the character
    public float m_SpeedModifier = 5f;
    public float m_OffsetY = 0f; // Adjust this if the path is not at ground level
    public float m_XMin = -5f;
    public float m_XMax = 5f;
    [Space]
    public bool LocalMovement;

    private Vector3 newPos = Vector3.zero;

    void Update()
    {
        // Get horizontal input (left/right arrow keys or A/D keys)
        float inputX = Input.GetAxis("Horizontal");

        // Calculate movement amount
        float newX = inputX * m_SpeedModifier * Time.deltaTime;

        // Update the new position in local space
        newPos = LocalMovement ? m_TransToMove.localPosition : m_TransToMove.position;
        newPos.x += newX;
        newPos.x = Mathf.Clamp(newPos.x, m_XMin, m_XMax); // Clamp position within limits

        // Ensure the player stays on the path (adjust Y position if needed)
        newPos.y = m_OffsetY;

        // Apply the new position in local space
        if (LocalMovement)
            m_TransToMove.localPosition = newPos;
        else
            m_TransToMove.position = newPos;
            
    }
    
}
