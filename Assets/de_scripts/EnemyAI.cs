
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private GameObject player;

    private Transform _target;
    private NavMeshAgent _enemy;
    private bool _seePlayer;
    void Start()
    {
        _enemy = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        _target = player.transform;Newpoint();
    }

    private void Newpoint()
    {
        _target = points[Random.Range(0, points.Count)];
    }
}
