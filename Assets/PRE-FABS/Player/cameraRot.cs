using UnityEngine;

public class cameraRot : MonoBehaviour
{

    public GameObject playerCamera;
    [SerializeField] private setttings settings;
    
    private float _mouseX;
    private float _mouseY;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _mouseY = Mathf.Clamp(-Input.GetAxis("Mouse Y")* settings.mouseSens + _mouseY, -40, 35);
        
        playerCamera.transform.localEulerAngles = new Vector3(_mouseY, 0, 0);

    }
}
