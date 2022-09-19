using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    [Header("Target Characteristics")] 
    [SerializeField] public float targetSpeed = 2f;
    [SerializeField] public bool isPressed = false;
    MainManager _mainManager;
    
    
    [Header("Target Components")]
    private Rigidbody2D _targetRigidbody2D;
    private BoxCollider2D _targetBoxCollider2D;

    void Awake()
    {
        _targetRigidbody2D = GetComponent<Rigidbody2D>();
        _targetBoxCollider2D = GetComponent<BoxCollider2D>();
        _mainManager = FindObjectOfType<MainManager>();
    }
    
    void FixedUpdate()
    {
        TargetMovement();
    }
    
    void TargetMovement()       // Move the target on x-axis;
    {
        if (isPressed)
        {
            _targetRigidbody2D.velocity = Vector2.zero;
            return;
        }
        float newSpeed = targetSpeed * _mainManager.Rounds;
        _targetRigidbody2D.velocity = new Vector2(newSpeed, 0f) ;
       // Debug.LogError(newSpeed);
    }
    
    
    void OnTriggerEnter2D(Collider2D other) // if the target collide with the boxes makes the speed negative to move to the other direction
    {
        if (other.tag == "Colliders")
        {
            targetSpeed = -targetSpeed;
           // Debug.LogError(targetSpeed);
        }
    }
}
