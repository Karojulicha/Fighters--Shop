using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerNetwork : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody Rb;
    private Vector3 moveDirection;

    
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        handleInput();
    }

    void handleInput ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontal * speed,0f, vertical * speed).normalized;
    }

}
