using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class jumping : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector2(0, jump));
        }
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetButtonDown("Jump")) ;

    //}
    // rb.Addforce(New vector2(rb.velocity.x, jump));
    //{



}
