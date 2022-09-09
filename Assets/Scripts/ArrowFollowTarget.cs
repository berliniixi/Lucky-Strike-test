using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFollowTarget : MonoBehaviour
{
    [Header("Arrow Characteristics")] 
    [SerializeField] private float arrowSpeed;
    /*
    [SerializeField] private float midpoint; // The difference between arrowPosition and the targetPosition; 
    */

    [Header("Arrow Components")] 
    [SerializeField] private Transform Target;
    private Rigidbody2D _arrowRigidbody2D;
    private BoxCollider2D _arrowBoxCollider2D;
    private Vector2 arrowPosition;
    private Vector2 targetPosition;


    private void FixedUpdate()
    {
        /*
        FollowTheTarget();
    */
    }
     
    public void FollowTheTarget() // When the player will press the button the arrow will follow the last position of the target;
    {
        Debug.Log("Here");
        
        arrowPosition = transform.position;
        targetPosition = Target.position;
        transform.position = Vector2.Lerp(arrowPosition, targetPosition, Time.deltaTime);

       
    }
}
