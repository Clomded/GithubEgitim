using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shotgun : MonoBehaviour
{
    private Vector2 mousePos;
    private Vector2 playerPos;
    private float angle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtCamera();
    }

    void LookAtCamera()
    {
        mousePos = Input.mousePosition;
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Debug.Log(mousePos);
        Debug.Log(playerPos);

        angle = Mathf.Atan((mousePos.y - playerPos.y)/(mousePos.x - playerPos.x));
        Debug.Log("angle");
        Debug.Log(angle);
        Debug.Log("angle");


        this.transform.rotation = Quaternion.Euler(transform.rotation.x,transform.rotation.y,angle);
    }


}
