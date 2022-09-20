using TMPro;
using UnityEngine;



public class ShowRewardScript : MonoBehaviour
{
     public TextMeshProUGUI showRewards;
     public TextMeshProUGUI showRewards1;
     public TextMeshProUGUI showRewards2;

     RandomRewards _randomRewards;

     int rewards = 0;

    void Start()
    {
        showRewards.gameObject.SetActive(false);
        showRewards1.gameObject.SetActive(false);
        showRewards2.gameObject.SetActive(false);
        _randomRewards = GetComponent<RandomRewards>();
    }

    public void EnableAllText() // Make the rewards appear
    {
        showRewards.gameObject.SetActive(true);
        showRewards1.gameObject.SetActive(true);
        showRewards2.gameObject.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D other) //When the bag collide with ground it show the reward
    {

        //_randomRewards.GetReandomRewards();
            
        //var index = Random.Range(0, 4);
            
        showRewards.text = _randomRewards.RandomMethodCollector().ToString();
        showRewards1.text = _randomRewards.RandomMethodCollector().ToString();
        showRewards2.text = _randomRewards.RandomMethodCollector().ToString();
        

        if (other.tag == "Bag")
        {
            showRewards.gameObject.SetActive(true);
            SaveDataRewards(showRewards);
            Debug.Log(showRewards);
        }
        else if(other.tag == "Bag1")
        {
            showRewards1.gameObject.SetActive(true);
            SaveDataRewards(showRewards1);
            //int.TryParse(showRewards1.text, out rewards);
            //rewards = int.Parse(showRewards1.text);
            //PlayerPrefs.SetInt("Rewards", rewards);
            //PlayerPrefs.GetInt("Rewards", rewards);
            //Debug.Log(rewards);
            Debug.Log(showRewards1);
        } 
        else if (other.tag == "Bag2")
        {
            showRewards2.gameObject.SetActive(true);
            SaveDataRewards(showRewards2);
            Debug.Log(showRewards2);
        }
    }

    void SaveDataRewards(TextMeshProUGUI rewardText)
    {
        int.TryParse(showRewards1.text, out rewards);
        //rewards = int.Parse(rewardText.text);
        PlayerPrefs.SetInt("Rewards", rewards);
        PlayerPrefs.GetInt("Rewards", rewards);
        Debug.Log(rewards);
    }
}

