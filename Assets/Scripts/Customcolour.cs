using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class VertexColorTest : MonoBehaviour
{
    void Start()
    {
        var mesh = new Mesh();

        mesh.vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0)
        };

        mesh.triangles = new int[] { 0, 1, 2 };

        mesh.colors = new Color[]
        {
            Color.red,
            Color.green,
            Color.blue
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
    }
}

