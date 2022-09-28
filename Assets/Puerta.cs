using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] float AngleY = 90.0f;
    private float targetValue = 0.0f;
    private float currentValue = 0.0f;
    private float easing = 0.05f;
    [SerializeField] GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentValue += (targetValue - currentValue) * easing;
        target.transform.rotation = Quaternion.identity;
        target.transform.Rotate(0, currentValue, 0);
    }

    public void OnEnter()
    {
        
        targetValue = AngleY;
        currentValue = 0.0f;
        
    }

    public void OnExit()
    {
        currentValue = AngleY;
        targetValue = 0.0f;
    }
}
