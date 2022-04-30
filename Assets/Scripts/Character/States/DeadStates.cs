﻿using UnityEngine;
using UnityEngine.AI;

public class DeadState : EnemyStates
{
    private EnemyControllerWithFSM controller;
    private readonly NavMeshAgent agent;
    private readonly Animator animator;
    private Collider collider;

    public DeadState(EnemyControllerWithFSM controller, NavMeshAgent agent, Animator animator, Collider collider)
    {
        this.controller = controller;
        this.agent = agent;
        this.animator = animator;
        this.collider = collider;
    }

    public void Tick()
    {
        Object.Destroy(controller.gameObject, 2f);
    }

    public void OnEnter()
    {
        collider.enabled = false;
        agent.enabled = false;
        animator.SetBool("Dead", true);
    }
    public void OnExit()
    {

    }
}