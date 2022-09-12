using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu (fileName = "Lucky Strike Rewards" , menuName = ("SO/LuckyStrikeRewards") )]
public class LuckyStrikeSO : ScriptableObject
{
    public List<LuckyStrikeRewards> rewards;
}

[Serializable]
public class LuckyStrikeRewards
{
    public int empty;
    public Sprite EmptySprite;
    public int gems;
    public Sprite gemSprite;
    public int money;
    public Sprite moneySprite;
    public int exp;
    public Sprite expSprite;
    public int energy;
    public Sprite energySprite;
}


