﻿using System;
using System.Threading;

public class MediumHealthPotion : IConsumableItem
{
    public string name => "중급 체력포션";
    public string description => "체력 +50 회복";

    public void OnUsed(Character target)
    {
        Console.WriteLine("중급 체력포션을 사용합니다. 체력을 +50 회복합니다.");

        target.health += 50;

        if (target.health > target.stats.maxHealth)
        {
            target.health = target.stats.maxHealth;

        }

        Thread.Sleep(1000);
    }
}