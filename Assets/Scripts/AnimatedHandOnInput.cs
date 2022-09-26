using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AnimatedHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty GripAnimationAction;
    public Animator handAnimator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float PinchTriggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", PinchTriggerValue);

        float GripTriggerValue = GripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", GripTriggerValue);
    }
}
