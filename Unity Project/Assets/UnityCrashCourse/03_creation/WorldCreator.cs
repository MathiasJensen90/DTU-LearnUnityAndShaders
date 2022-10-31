using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (var x = 0; x < 10; x++)
        {
            for(var z = 0; z < 10; z++)
            {
                var height = Mathf.PerlinNoise(x * 0.13f + 10.0f, z * 0.07f + 3.0f) + Mathf.PerlinNoise(x * 0.17f, z * 0.24f);
                var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height * 2.0f - 7.0f, z);
            }
        }
    }
}
