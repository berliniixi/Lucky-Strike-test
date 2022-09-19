using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRewards : MonoBehaviour
{
    [SerializeField] private LuckyStrikeSO _luckyStrikeSo;
    /*
    private LuckyStrikeRewards luckyStrikeRewards;
    */


    int RandomGemsPicker() // Randomize the elements that the "gems" list have 
    {
        int randomGem = Random.Range(0, _luckyStrikeSo.gems.Count); // Picking a random gem
        LuckyStrikeGems gemsValue = _luckyStrikeSo.gems[randomGem];
        randomGem = Random.Range(0, _luckyStrikeSo.gems.Count);
       // Debug.Log("Gems : " + gemsValue.gems + " " + " From Element : " + randomGem + "" + " Sprite : " + gemsValue.gemSprite);
        
        return gemsValue.gems;
    }
    
    int RandomMoneyPicker() // Randomize the elements that the "money" list have 
    {
        int randomMoney = Random.Range(0, _luckyStrikeSo.money.Count); // Picking a random value from money 
        LuckyStrikeMoney moneyValue = _luckyStrikeSo.money[randomMoney]; 
      //  Debug.Log("Money : "+ moneyValue.money + " " + " From Element : " + randomMoney  + " Sprite : " + moneyValue.moneySprite);
        
        return moneyValue.money;
    }
    
    int RandomPowerPicker()  // Randomize the elements that the "power" list have 
    {
        int randomPower = Random.Range(0, _luckyStrikeSo.power.Count); // Picking a random value from Power
        LuckyStrikePower powerValue = _luckyStrikeSo.power[randomPower]; 
       // Debug.Log("Power : "+ powerValue.power + " " + " From Element : " + randomPower + " Sprite : " +powerValue.powerSprite);
        
        return powerValue.power;
    }
    
    int RandomExpPicker()   // Randomize the elements that the "exp" list have 
    {
        int randomExp = Random.Range(0, _luckyStrikeSo.exp.Count); // Picking a random value from Exp
        LuckyStrikeExp expValue = _luckyStrikeSo.exp[randomExp]; 
      //  Debug.Log("Exp : "+ expValue.exp + " " + " From Element : " + randomExp + " Sprite : " + expValue.expSprite);
        
        return expValue.exp;
    }
    
    int RandomLivesPicker()   // Randomize the elements that the "lives" list have 
    {
        int randomLives = Random.Range(0, _luckyStrikeSo.lives.Count); // Picking a random value from Lives
        LuckyStrikeLives livesValue = _luckyStrikeSo.lives[randomLives]; 
       // Debug.Log("Lives : "+ livesValue.lives + " " + " From Element : " + randomLives + " Sprite : " + livesValue.livesSprite);
        
        return livesValue.lives;
    }

    /*public void GetReandomRewards()
    {
        int randomNum = Random.Range(0, _luckyStrikeSo.rewards.Count); // Picking a random value from Lives
        Debug.LogError(randomNum);
        luckyStrikeRewards = _luckyStrikeSo.rewards[randomNum];
    }*/
    

     public int RandomMethodCollector() // Create a method that hold a List of all the methods that randomized their list 
    {
        List<int> temp = new List<int>();

        //add to sack
        temp.Add(RandomGemsPicker());
        temp.Add(RandomExpPicker());
        temp.Add(RandomMoneyPicker());
        temp.Add(RandomPowerPicker());
        temp.Add(RandomLivesPicker());
        
        var i = Random.Range(0, temp.Count);
        
        //show value (Value when the player hit the sack)
  
       // Debug.Log(temp[i] + " Value");
        
        int result = temp[i];
        
        return result;
        /*var index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                return luckyStrikeRewards.gems;
                break;
            case 1:
                return luckyStrikeRewards.exp;
                break;
            case 2:
                return luckyStrikeRewards.money;
                break;
            case 3:
                return luckyStrikeRewards.power;
                break;
            case 4:
                return luckyStrikeRewards.lives;
                break;
        }
        return 0;*/
    }
     
}
