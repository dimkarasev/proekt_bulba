
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    [SerializeField] private RectTransform valRectTrans;
    [SerializeField] private GameObject gpui;
    [SerializeField] private GameObject lolUDead;
    float _health = 100;
    // Start is called before the first frame update
    public void DealDamage(float damage)
    {
        _health -= damage;
        valRectTrans.localScale = new Vector2(_health/100, 1);
        if (_health<=1)
        {
            gpui.SetActive(false);
            lolUDead.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
