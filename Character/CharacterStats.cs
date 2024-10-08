﻿public struct CharacterStats
{
    public CharacterStats(
        int maxHealth = 100,
        int minAttack = 10,
        int maxAttack = 20,
        int minArmor = 5,
        int maxArmor = 10,
        int minAgility = 1,
        int maxAgility = 3, 
        float criticalRate = 0.1f,
        float avoidRate = 0.1f)
    {
        this.maxHealth = maxHealth;
        this.minAttack = minAttack;
        this.maxAttack = maxAttack;
        this.minArmor = minArmor;
        this.maxArmor = maxArmor;
        this.minAgility = minAgility;
        this.maxAgility = maxAgility;
        this.criticalRate = criticalRate;
        this.avoidRate = avoidRate;
    }

    public int maxHealth { get; set; }
    public int minAttack { get; set; }
    public int maxAttack { get; set; }
    public int minArmor { get; set; }
    public int maxArmor { get; set; }
    public int minAgility { get; set; }
    public int maxAgility { get; set; }
    public float criticalRate { get; set; }
    public float avoidRate { get; set; }

    public static CharacterStats operator +(CharacterStats stat1, CharacterStats stat2)
    {
        CharacterStats result = new CharacterStats(
            stat1.maxHealth + stat2.maxHealth,
            stat1.minAttack + stat2.minAttack,
            stat1.maxAttack + stat2.maxAttack,
            stat1.minArmor + stat2.minArmor,
            stat1.maxArmor + stat2.maxArmor,
            stat1.minAgility + stat2.minAgility,
            stat1.maxAgility + stat2.maxAgility,
            stat1.criticalRate + stat2.criticalRate,
            stat1.avoidRate + stat2.avoidRate);
        return result;
    }

    public static CharacterStats operator -(CharacterStats stat1, CharacterStats stat2)
    {
        CharacterStats result = new CharacterStats(
            stat1.maxHealth - stat2.maxHealth,
            stat1.minAttack - stat2.minAttack,
            stat1.maxAttack - stat2.maxAttack,
            stat1.minArmor - stat2.minArmor,
            stat1.maxArmor - stat2.maxArmor,
            stat1.minAgility - stat2.minAgility,
            stat1.maxAgility - stat2.maxAgility,
            stat1.criticalRate - stat2.criticalRate,
            stat1.avoidRate + stat2.avoidRate);
        return result;
    }
}