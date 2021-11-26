using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float verticalInput;
    public float turnSpeed = 20f;
    private float zMax = 450f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput);

        if (transform.position.z > zMax)
        {
            Debug.Log("The End");
            Time.timeScale = 0;
        }

    }
}
