using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllady : MonoBehaviour
{
    private Animator animator;
    private CharacterController charController;
    public float Downaccel = 1f;
    public float smoothBlend = 0.1f;
    public string v = "vertical";
    public string h = "horizontal";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        charController.Move(Vector3.down*Downaccel*Time.deltaTime);

        //animator.SetFloat(v, 0);
       // animator.SetFloat(h, 0);

        if (Input.GetKey(KeyCode.I))
        {
            if (animator.GetFloat(v) < 1)
            {
                animator.SetFloat(v, animator.GetFloat(v) + smoothBlend);
            }
        } else
        if (Input.GetKey(KeyCode.M))
        {
            if (animator.GetFloat(v) > -1)
            {
                animator.SetFloat(v, animator.GetFloat(v) - smoothBlend);
            }
        }
        else
        {
            if (animator.GetFloat(v) < 0)
            {
                animator.SetFloat(v, animator.GetFloat(v) + smoothBlend);
            }
            if (animator.GetFloat(v) > 0)
            {
                animator.SetFloat(v, animator.GetFloat(v) - smoothBlend);
            }
        }
        if (Input.GetKey(KeyCode.J))
        {
            if (animator.GetFloat(h) < 1)
            {
                animator.SetFloat(h, animator.GetFloat(h) - smoothBlend);
            }
        } else
        if (Input.GetKey(KeyCode.K))
        {
            if (animator.GetFloat(h) < 1)
            {
                animator.SetFloat(h, animator.GetFloat(h) + smoothBlend);
            }
        }
        else
        {
            if (animator.GetFloat(h) < 0)
            {
                animator.SetFloat(h, animator.GetFloat(h) + smoothBlend);
            }
            if (animator.GetFloat(h) > 0)
            {
                animator.SetFloat(h, animator.GetFloat(h) - smoothBlend);
            }
        }
    }
}
