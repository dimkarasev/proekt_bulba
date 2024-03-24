using UnityEngine;

public class pulatel : MonoBehaviour
{
    [SerializeField] private GameObject bulba;
    [SerializeField] private Transform rotationpoint;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulba, rotationpoint.position , rotationpoint.rotation);
        }
    }
}
