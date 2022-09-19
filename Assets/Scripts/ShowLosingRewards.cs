using System.Collections;
using UnityEngine;

public class ShowLosingRewards : MonoBehaviour
{
    private ShowRewardScript _showRewardScript;
    private RandomRewards _randomRewards;
    
    /*
    private ArrowFollowTarget _arrowFollowTarget;
    */
    void Start()
    {
        _showRewardScript = FindObjectOfType<ShowRewardScript>(); 
        _randomRewards = FindObjectOfType<RandomRewards>();
        /*
        _arrowFollowTarget = GetComponent<ArrowFollowTarget>();
        */

    }
    
    // When the Arrow does not collide with any of the target (Collide with the square) then do the follow 
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Arrow")
        {
            //added the below 3 lines
            _showRewardScript.showRewards.text = _randomRewards.RandomMethodCollector().ToString();
            _showRewardScript.showRewards1.text = _randomRewards.RandomMethodCollector().ToString();
            _showRewardScript.showRewards2.text = _randomRewards.RandomMethodCollector().ToString();
            StartCoroutine(ShowLostRewards());
           // Debug.LogError("You lost");
        }
    }
    
    IEnumerator ShowLostRewards() // It show the rewards with 2 sec delay, when the player miss the target 
    {
        yield return new WaitForSeconds(2);
        _showRewardScript.EnableAllText();
    }
}
