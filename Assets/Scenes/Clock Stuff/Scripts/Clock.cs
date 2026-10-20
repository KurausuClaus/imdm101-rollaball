using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hourPivot, minutePivot, secondPivot;

    void Awake() {
        // DateTime curTime = DateTime.Now;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hourPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, -30f * DateTime.Now.Hour);
        minutePivot.localRotation = Quaternion.Euler(0.0f, 0.0f, -6f * DateTime.Now.Minute);
        secondPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, -6f * DateTime.Now.Second);
        Debug.Log(DateTime.Now);
    }
}
