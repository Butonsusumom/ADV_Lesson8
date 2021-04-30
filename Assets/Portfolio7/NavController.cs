using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavController : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent agent;
    public Animator animator;
    public string parametrBoolean;
    bool b = false;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        b = !b;
        animator.SetBool(parametrBoolean, b);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            
            animator.SetBool(parametrBoolean, false);

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;

            }

         
        }

        animator.SetBool(parametrBoolean, true);
    }
}
