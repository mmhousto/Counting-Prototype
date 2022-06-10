using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter Instance { get; private set; }

    public TextMeshProUGUI CounterText;

    public int Count = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count: " + Count;
    }
}
