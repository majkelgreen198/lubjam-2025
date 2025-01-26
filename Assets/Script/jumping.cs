using UnityEngine;

public class jumping : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump;

    [SerializeField]
    private GameObject massCenterOffset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.centerOfMass = massCenterOffset.transform.localPosition;
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            rb.AddForceY(jump);
        }
    }
}
