using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Transform _target;
    private NavMeshAgent _enemy;
    private float _cooldown;
    void Start()
    {
        _enemy = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        _target = player.transform;
        _enemy.destination = _target.position;

        if (Vector3.Distance(_target.position, transform.position) < 5 && _cooldown<0)
        {
            player.GetComponent<playerhealth>().DealDamage(10);
            _cooldown = 0.3f;
        }

        _cooldown -= Time.deltaTime;
    }


}
