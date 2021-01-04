﻿using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    LootAngle myLootAngle = new LootAngle(45);

    void Start()
    {
        int radius = 5;
        int angle = 15;
        //every call will advance the angle!
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
    }
    void AddingNumbers(float num1, float num2)
    {
        float resultingNumber;
        resultingNumber = num1 + num2;
        AddingNumbers(5.5f, 18.9f);
    }
    void SpawnPotion(int angle)
    {
        int radius = 5;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
    public class LootAngle
    {
        int angle;
        int step;

        public LootAngle(int increment)
        {
            step = increment;
            angle = 0;
        }

        public int NextAngle()
        {
            int currentAngle = angle;
            angle = Helpers.WrapAngle(angle + step);

            return currentAngle;
        }
    }
}

