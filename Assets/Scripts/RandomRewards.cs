using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class RandomRewards : MonoBehaviour
{
    [SerializeField] private LuckyStrikeSO _luckyStrikeSo;

    public void AppendTheWinningRewards() // calling this methods to the ArrowFollowTarget script 
    {
        RandomMethodCollector();
    }

    public void AppendTheLosingRewards()
    {
        test();
    }
    int RandomGemsPicker() // Randomize the elements that the gems list have 
    {
        int randomGem = Random.Range(0, _luckyStrikeSo.gems.Count); // Picking a random gem
        LuckyStrikeGems gemsValue = _luckyStrikeSo.gems[randomGem]; 
        Debug.Log("Gems : "+ gemsValue.gems + " " + " From Element : "+ randomGem  + " Sprite : " + gemsValue.gemSprite);
        return gemsValue.gems;
    }

    int RandomMoneyPicker() // Randomize the elements that the money list have 
    {
        int randomMoney = Random.Range(0, _luckyStrikeSo.money.Count); // Picking a random value from money 
        LuckyStrikeMoney moneyValue = _luckyStrikeSo.money[randomMoney]; 
        Debug.Log("Money : "+ moneyValue.money + " " + " From Element : " + randomMoney  + " Sprite : " + moneyValue.moneySprite);
        return moneyValue.money;
    }
    
    int RandomPowerPicker()  // Randomize the elements that the power list have 
    {
        int randomPower = Random.Range(0, _luckyStrikeSo.power.Count); // Picking a random value from Power
        LuckyStrikePower powerValue = _luckyStrikeSo.power[randomPower]; 
        Debug.Log("Power : "+ powerValue.power + " " + " From Element : " + randomPower + " Sprite : " +powerValue.powerSprite);
        return powerValue.power;
    }
    
    int RandomExpPicker()   // Randomize the elements that the exp list have 
    {
        int randomExp = Random.Range(0, _luckyStrikeSo.exp.Count); // Picking a random value from Exp
        LuckyStrikeExp expValue = _luckyStrikeSo.exp[randomExp]; 
        Debug.Log("Exp : "+ expValue.exp + " " + " From Element : " + randomExp + " Sprite : " + expValue.expSprite);
        return expValue.exp;
    }
    

    void RandomMethodCollector() // Create a method that hold an array of all the methods that randomized their list 
    {
        /*List<int> temp = new List<int>();
        temp.Add(RandomGemsPicker());
        temp.Add(RandomExpPicker());
        temp.Add(RandomMoneyPicker());
        temp.Add(RandomPowerPicker());
        var index = Random.Range(0, temp.Count);
        //add to sack
        
        //remove from list
        temp.RemoveAt(index);
        Debug.Log(temp[index]);
        Debug.Log(index);*/
        
        var arrayOfMethods = new Int32[] {RandomGemsPicker(), RandomExpPicker(), RandomMoneyPicker(), RandomPowerPicker()};
        var arrayOfMethodsIndex = Random.Range(0, arrayOfMethods.Length);
        Debug.Log(arrayOfMethods.Length); // Size of the array
        Debug.Log(arrayOfMethods[arrayOfMethodsIndex]); // Element from the list 

    }

    void test()
    {
        var arrayOfMethods = new Int32[] {RandomGemsPicker(), RandomExpPicker(), RandomMoneyPicker(), RandomPowerPicker()};
        var arrayOfMethodsIndex = Random.Range(0, arrayOfMethods.Length);
        Debug.Log(arrayOfMethods.Length); // Size of the array
    }

}