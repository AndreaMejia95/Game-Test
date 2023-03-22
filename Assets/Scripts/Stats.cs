using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour
{
    public static Stats instance;

    public ParticleSystem openChest;
    public Slider collectIt;

    [Range(0, 10)] public int collectedItems;


    private void Awake() {
        instance = this;
    }


    void Update()
    {
        collectIt.value = collectedItems;
    }

    void Start()
    {
        collectIt.value = collectedItems;

    }

    public void AddItems(int amount)
    {
        Instantiate(openChest, transform.position, Quaternion.identity);
    }
}
