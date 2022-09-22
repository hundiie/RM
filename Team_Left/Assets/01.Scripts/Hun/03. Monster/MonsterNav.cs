using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.PlayerLoop;

public class MonsterNav : MonoBehaviour
{
    private MonsterStatus _MonsterStatus;
    private NavMeshAgent _NavMeshAgent;

    private void Awake()
    {
        _MonsterStatus = GetComponent<MonsterStatus>();
        _NavMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        _NavMeshAgent.speed = _MonsterStatus.Speed;
    }

    public void AddTarget(Vector3 Vector)
    {
        _NavMeshAgent.destination = Vector;
    }
}
