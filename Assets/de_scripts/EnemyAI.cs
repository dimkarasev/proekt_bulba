using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{
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
        _target = player.transform;
        _enemy.destination = _target.position;
    }


}
