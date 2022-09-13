using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


[CreateAssetMenu (fileName = "Lucky Strike Rewards" , menuName = ("SO/LuckyStrikeRewards") )]
public class LuckyStrikeSO : ScriptableObject
{
    public List<LuckyStrikeGems> gems;
    public List<LuckyStrikeMoney> money;
    public List<LuckyStrikePower> power;
    public List<LuckyStrikeExp> exp;
    
}

[Serializable]
public class LuckyStrikeGems
{
    public int gems;
    public Sprite gemSprite;
}
[Serializable]

public class LuckyStrikeMoney
{
    public int money;
    public Sprite moneySprite;
}
[Serializable]

public class LuckyStrikePower
{
    public int power;
    public Sprite powerSprite;
}
[Serializable]

public class LuckyStrikeExp
{
    public int exp;
    public Sprite expSprite;
}

