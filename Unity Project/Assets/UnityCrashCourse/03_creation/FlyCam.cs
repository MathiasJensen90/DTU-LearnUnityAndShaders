using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FlyCam : MonoBehaviour
{
    private Vector3 look;
    public GameObject marble;

    // Update is called once per frame
    void Update()
    {
        // Move around
        var moveAmount = 10.0f * Time.deltaTime;
        transform.Translate(Input.GetAxis("Horizontal") * moveAmount, 0, Input.GetAxis("Vertical") * moveAmount, Space.Self);

        // Look around
        look.y += Input.GetAxis("Mouse X");
        look.x += -Input.GetAxis("Mouse Y");
        look.x = Mathf.Clamp(look.x, -35.0f, 35.0f);
        transform.localEulerAngles = look;

        // Shoot marbles
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var m = Instantiate(marble);
            m.transform.position = transform.position;
            m.GetComponent<Rigidbody>().AddForce(transform.forward * 10.0f, ForceMode.Impulse);
        }
    }
}
