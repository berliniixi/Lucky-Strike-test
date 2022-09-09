using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFollowTarget : MonoBehaviour
{
    [Header("Arrow Characteristics")] 
    [SerializeField] float arrowSpeed = 3f;
    [SerializeField] public bool allowArrowHit = false; 
        
    [Header("Arrow Components")]
    [SerializeField] private Transform Target;
    private Rigidbody2D _arrowRigidbody2D;
    private BoxCollider2D _arrowBoxCollider2D;
    private Vector2 arrowPosition; 
    private Vector2 targetPosition;


    [Header("Reference to other Scripts")] private TargetScript _targetScript;

    void Awake()
    {
        _targetScript = GetComponent<TargetScript>();
    }
    
    public void FixedUpdate()
    {
        if (!allowArrowHit)
        {
            Debug.Log("allowArrowHit : " + allowArrowHit );
            return;
        }
        FollowTheTarget();    
    }

      void FollowTheTarget() // arrow will follow the last position of the target;
    {
        /*if (!allowArrowHit)
        {
            Debug.Log("allowArrowHit : " + allowArrowHit );
            return;
        }*/
        arrowPosition = transform.position;
        targetPosition = Target.position;
        transform.position = Vector2.Lerp(arrowPosition, targetPosition, arrowSpeed * Time.deltaTime);
        /*transform.up = Target.transform.position - transform.position;*/ // Rotate the LOCAL position on the UP direction from the Target;
    }
}
