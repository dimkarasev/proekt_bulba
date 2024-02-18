using UnityEngine;

public class gorachaja_bulba : MonoBehaviour
{
    private Rigidbody _myPlayer;
    [SerializeField] private float power;
    [SerializeField] private float lifetime;
    [SerializeField] private float damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        _myPlayer = GetComponent<Rigidbody>();
        _myPlayer.AddForce(transform.rotation * Vector3.forward * power);
        Invoke("DestroyNafig", lifetime);
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.TryGetComponent(out enemyhealth component))
        {
            col.gameObject.GetComponent<enemyhealth>().health -= damage;
        }
        DestroyNafig();
    }

    private void DestroyNafig()
    {
        Destroy(gameObject);
    }
}
