using UnityEngine;
using System.Collections;

public class OpenCloseAction : MonoBehaviour {

    public string onTriggerEnter;
    public string onTriggerExit;
    public Animator animator;

    public void OnTriggerEnter()
    {
        animator.SetTrigger(onTriggerEnter);
    }

    public void OnTriggerExit()
    {
        animator.SetTrigger(onTriggerExit);
    }
}
