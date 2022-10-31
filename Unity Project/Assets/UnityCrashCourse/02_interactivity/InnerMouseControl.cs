using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerMouseControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.05f, 0);
        transform.localPosition = transform.localPosition + new Vector3(0, Input.GetAxis("Vertical") * 0.02f, 0);
    }
}
