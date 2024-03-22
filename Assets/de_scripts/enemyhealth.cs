
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public float health = 100;
    public GameObject endGaneGoodEndingScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            endGaneGoodEndingScreen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
