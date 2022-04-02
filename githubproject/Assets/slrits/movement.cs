using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class movement : MonoBehaviour
{
    
    public float Speed = 5f;
    public float StaticSpeed = 10f;

    public float JumpForce = 300f;

    //что бы эта переменная работала добавьте тэг "Ground" на вашу поверхность земли
    private bool _isGrounded;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        StaticMovementLogic();

        JumpLogic();

        MovementLogic();
    }
    
    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }
    public void StaticMovementLogic()
    {
        
        Vector3 movement = new Vector3(0.0f, 0.0f, 1.0f);
        transform.Translate(movement * StaticSpeed * Time.fixedDeltaTime);
    }

    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGrounded)
            {
                _rb.AddForce(Vector3.up * JumpForce);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
}