using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [Header("Characteristics")]
    
    
    [Header("Components")]
    private TargetScript _targetScript;
    [SerializeField] private Transform target;

    
    [Header("Reference to other Scripts")]
    private ArrowFollowTarget _arrowFollowTarget;
    [SerializeField] private ArrowSpawnerScript _arrowSpawnerScript;
    private RandomRewards _randomRewards;
    private ShowRewardScript _showRewardScript;
    
    
    int counter = 0;
    private static bool _created = false;

   /*  private void Awake()
    {
        if (!_created)
        {
            DontDestroyOnLoad(this.gameObject);
            _created = true;
        }
    } */

    void Start()
    {
        _targetScript = FindObjectOfType<TargetScript>();
        _randomRewards = GetComponent<RandomRewards>();
        _showRewardScript = GetComponent<ShowRewardScript>();
    }
    
    public void PressToStopTarget() // Button.OnClick => Method that when the player press the button it will stop the target and the arrow will go to the target position;
    {
        _targetScript.isPressed = true; // Stop the target from movement
    }

    private void PressToShootTarget() // Button.OnClick => The arrow must go to the position of the target;
    {
        _arrowFollowTarget.allowArrowHit = true;
        _arrowFollowTarget.FixedUpdate();// Start the arrow going to the target;    
    }

    public void PressToSpawn()
    {
        _arrowSpawnerScript.ArrowInstantiate();
        _arrowSpawnerScript.arrowIsInstantiate = true; // here must stop the instance of the arrow
        _arrowFollowTarget = FindObjectOfType<ArrowFollowTarget>();
        PressToShootTarget();
    }
    

    /* public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        counter++;
        Debug.Log(counter);
    } */
}
