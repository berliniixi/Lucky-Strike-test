using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFollowTarget : MonoBehaviour
{
    [Header("Arrow Characteristics")] 
    [SerializeField] float arrowSpeed = 3f;
     public bool allowArrowHit = false;
    
    [Header("Arrow Components")]
    private Transform Target;
    private Rigidbody2D _arrowRigidbody2D;
    private Vector2 arrowPosition; 
    private Vector2 targetPosition;
    private GameObject _rope;
    
    [Header("Reference to other Scripts")] 
    private TargetScript _targetScript;
    private ArrowSpawnerScript _arrowSpawnerScript;
    private ShowLosingRewards _showLosingRewards;
    
    void Awake()
    {
        _targetScript = GetComponent<TargetScript>(); 
        _arrowSpawnerScript = GetComponent<ArrowSpawnerScript>();
        Target = FindObjectOfType<TargetScript>().gameObject.transform;
        
    }
    
    public void FixedUpdate()
    {
        if (!allowArrowHit)
        {
            return;
        }
        FollowTheTarget();    
    }

      void FollowTheTarget() // arrow will follow the last position of the target;
    {
        arrowPosition = transform.position;
        targetPosition = Target.position;
        transform.position = Vector2.Lerp(arrowPosition, targetPosition,  arrowSpeed * Time.deltaTime);
        /*transform.up = Target.transform.position - transform.position;*/ // Rotate the LOCAL position on the UP direction from the Target;
    }

      void OnTriggerEnter2D(Collider2D other) // When the arrow collide with the GoalCircle must cut the rope and the bag must fall down;  
      {

          if (other.tag == "GoalColliders")
          {
              other.GetComponentInChildren<Rigidbody2D>().simulated = enabled; //  It gets the child component of the GaolCircle
                                            // and its enable the simulated to make the rope to has physics 
          }

      }
}
