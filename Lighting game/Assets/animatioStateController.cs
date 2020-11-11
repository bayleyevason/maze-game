using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatioStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash = Animator.StringToHash("isWalkingHash");
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        bool isWalking = animator.GetBool("isWalkingHash");
        bool forwardPressed = Input.GetKey("w");
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalkingHash", true);
        }
        if(isWalking && !forwardPressed)
        {
            animator.SetBool("isWalkingHash", false);
        }
    }
}
