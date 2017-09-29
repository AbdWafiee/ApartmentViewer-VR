using UnityEngine;
using System.Collections;

public class Interactions : MonoBehaviour
{
    public bool doorClosed = false;
    public bool windowClosed = false;
    public float interactDist = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Debug.Log("B");
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDist))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    if (!doorClosed)
                    {
                        hit.collider.GetComponentInParent<OpenCloseAction>().OnTriggerEnter();
                        doorClosed = true;
                        Debug.Log("Door Open");
                    }

                    else
                    {
                        hit.collider.GetComponentInParent<OpenCloseAction>().OnTriggerExit();
                        doorClosed = false;
                        Debug.Log("Door Close");
                    }
                }
            }

            if (Physics.Raycast(ray, out hit, interactDist))
            {
                if (hit.collider.CompareTag("Window"))
                {
                    if (!windowClosed)
                    {
                        hit.collider.GetComponentInParent<OpenCloseAction>().OnTriggerEnter();
                        windowClosed = true;
                        Debug.Log("Window Open");
                    }

                    else
                    {
                        hit.collider.GetComponentInParent<OpenCloseAction>().OnTriggerExit();
                        windowClosed = false;
                        Debug.Log("Window Close");
                    }
                }
            }
        }
    }
}
