using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    private BuildingTypeSO buildingType;
    private float timer;
    private float timerMax;

    private void Awake()
    {
        buildingType = GetComponent<BuildingTypeHolder>().BuildingType;
        timerMax = buildingType.ResourceGeneratorData.timerMax;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer += timerMax;
            ResourceManager.Instance.AddResource(buildingType.ResourceGeneratorData.ResourceTypeSo, 1);
        }
    }
}
