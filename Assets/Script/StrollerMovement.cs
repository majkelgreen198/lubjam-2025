using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StrollerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _dd;
    [SerializeField] private Rigidbody2D _aa;
    [SerializeField] private Rigidbody2D _cc;

    [SerializeField] private float _speed = 150f;


    [SerializeField] private float _rotationSpeed = 300f;
    [SerializeField] private float _maxRotationSpeed = 100f;


    private float _moveInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void FixedUpdate()
    {
        _cc.AddTorque(_moveInput * _rotationSpeed * Time.fixedDeltaTime);
        if (Mathf.Abs(_cc.angularVelocity) > _maxRotationSpeed)
        {
            _cc.angularVelocity = Mathf.Sign(_cc.angularVelocity) * _maxRotationSpeed;
        }
    }
}
