using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    private Vector3 gravity;
    public float Gravity_Acc = -9.81f;
    private Vector3 velocity_acc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 new_position = Camera.main.transform.forward;
        controller.Move(new_position * speed * Time.deltaTime);
        velocity_acc.y += Gravity_Acc * Time.deltaTime;
        controller.Move(velocity_acc * Time.deltaTime);
    }
}
