using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{

    [SerializeField] GameObject cube1;
    [SerializeField] GameObject cube2;
    [SerializeField] GameObject cube3;

    LineRenderer lineRenderer;



    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        List<Vector3> positions = new List<Vector3>();

        positions.Add(cube1.transform.position);
        positions.Add(cube2.transform.position);
        positions.Add(cube3.transform.position);

        lineRenderer.numPositions = positions.Count;

        lineRenderer.SetPositions(positions.ToArray());
    
        
        
    }
}
