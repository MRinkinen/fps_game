using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public PlayerInput playerInput;
    public GameObject player_camera;
    public float moveSpeed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = playerInput.actions["Move"].ReadValue<Vector2>().x;
        float vertical = playerInput.actions["Move"].ReadValue<Vector2>().y;

        float horizontal_mouse = playerInput.actions["Look"].ReadValue<Vector2>().x;
        float vertical_mouse = playerInput.actions["Look"].ReadValue<Vector2>().y;

        gameObject.transform.Rotate(0, horizontal_mouse, 0);
        player_camera.transform.Rotate(-vertical_mouse, 0, 0);

        gameObject.transform.Translate(Vector3.forward * moveSpeed * vertical * Time.deltaTime);
        gameObject.transform.Translate(Vector3.right * moveSpeed * horizontal * Time.deltaTime);
    }
}























//float horizontal_mouse = playerInput.actions["Look"].ReadValue<Vector2>().x;

// gameObject.transform.Rotate(0, horizontal_mouse, 0);
