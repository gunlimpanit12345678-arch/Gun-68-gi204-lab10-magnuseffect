using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class AngularVelocity : MonoBehaviour
{
    public float angularSpeed = 0f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.aKey.isPressed)
        {
            _rb.angularVelocity = new Vector3(0,angularSpeed,0);    
        }
        else {_rb.angularVelocity = Vector3.zero; }
    }
}
