using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshWidthCalculator : MonoBehaviour
{
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            Mesh mesh = meshFilter.sharedMesh;
            if (mesh != null)
            {
                Bounds bounds = mesh.bounds;
                float width = bounds.size.x * transform.localScale.x; // オブジェクトのスケールも考慮
                Debug.Log("Mesh Width: " + width);
            }
        }
    }
}
