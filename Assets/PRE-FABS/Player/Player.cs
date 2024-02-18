using DG.Tweening;
using UnityEngine;


public class  Player : MonoBehaviour
{
    [SerializeField] private setttings settings;
    
    private Rigidbody _myPlayer;
    private bool _flashlightOn;
    private bool _inAir;
    private float _currentSpeed;
    private float _mouseX;
    private float _mouseY;
    private Camera _camera;

    void Start()
    {
        _myPlayer = GetComponent<Rigidbody>();
        DOTween.SetTweensCapacity(500, 50);
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Time.deltaTime*_currentSpeed*Vector3.forward);
            //_myPlayer.AddForce(Time.deltaTime*_currentSpeed*(Quaternion.Euler (0, _mouseX, 0)*Vector3.forward));
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Time.deltaTime*_currentSpeed*Vector3.back);
            //_myPlayer.AddForce(Time.deltaTime*_currentSpeed*(Quaternion.Euler (0, _mouseX, 0)*Vector3.back));
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Time.deltaTime*_currentSpeed*Vector3.left);
            //_myPlayer.AddForce(Time.deltaTime*_currentSpeed*(Quaternion.Euler (0, _mouseX, 0)*Vector3.left));
            

        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Time.deltaTime*_currentSpeed*Vector3.right);
            //_myPlayer.AddForce(Time.deltaTime*_currentSpeed*(Quaternion.Euler (0, _mouseX, 0)*Vector3.right));
        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.DOScaleY(0.5f,0.5f);
            _currentSpeed = settings.playerCrouchSpeed;
            _camera.DOFieldOfView(50, 0.5f);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            _currentSpeed = settings.playerRunSpeed;
            _camera.DOFieldOfView(70, 0.5f);
        }
        else
        {
            _currentSpeed = settings.playerDefaultSpeed;
            gameObject.transform.DOScaleY(1,0.5f);
            _camera.DOFieldOfView(60, 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !_inAir)
        {
            _myPlayer.AddForce(settings.jumpForce*Vector3.up);
        }
        /*
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_flashlightOn)
            {
                flashLight.intensity = 0;
                _flashlightOn = false;
            }
            else
            {
                flashLight.intensity = 2;
                _flashlightOn = true;
            }
        }
        */
        
        _mouseY = Mathf.Clamp(-Input.GetAxis("Mouse Y")*settings.mouseSens + _mouseY, -40, 35);
        _mouseX = Input.GetAxis("Mouse X")*settings.mouseSens + _mouseX;
        
        gameObject.transform.rotation = Quaternion.Euler(0, _mouseX, 0);
        
    }

    /*
    public void PushLocalWithPhysics(float velX, float velZ)
    {
        _myPlayer.AddForce
            (Time.deltaTime*_currentSpeed*(Quaternion.Euler(0, _mouseX, 0)*new Vector3(velX, 0, velZ)));
    }
    */
    private void OnCollisionExit(Collision _)
    {
        _inAir = true;
    }

    private void OnCollisionEnter(Collision _)
    {
        _inAir = false;
    }
}
