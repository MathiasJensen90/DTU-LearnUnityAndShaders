using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SurfaceAreaCalculator : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh; 

        var vertexArray = mesh.vertices;

        // visualises verts
        for (int i = 0; i < vertexArray.Length; i++)
        {
            Gizmos.DrawSphere((transform.position + vertexArray[i]) , 0.02f);
        }
        
    }
    
}
