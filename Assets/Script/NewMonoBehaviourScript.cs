using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _dd;
    [SerializeField] private Rigidbody2D _aa;
    [SerializeField] private Rigidbody2D _cc;

    [SerializeField] private float _speed = 150;


    [SerializeField] private float _rotationSpeed = 300f;

    private float _moveInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
 private void Update()

    {
        _moveInput = Input.GetAxisRaw("Horizontal");
        

    }
    private void FixedUpdate()
    {
        //_dd.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        //_aa.AddTorque( -_moveInput * _speed * Time.fixedDeltaTime);
        _cc.AddTorque(_moveInput * _rotationSpeed * Time.fixedDeltaTime);


    }
}
