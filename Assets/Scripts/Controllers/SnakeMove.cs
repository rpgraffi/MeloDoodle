using System.Linq;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;



public class SnakeMove : MonoBehaviour
{
    //[SerializeField] SpectrumAnalyzer analyzer = null;

    public float baseSpeed = 3f; 
    public float maxSpeed = 20f; 
    public float rotationSpeed = 200f;
    private float currentSpeed = 3f;

    public Vector3 minScale;
    public Vector3 maxScale;

    public float loudnessSensitivity = 100;
    public float threshold = 4.5f;


    void Start()
    {

        // Assuming SpectrumAnalyzer is in the same game object

    }

    void FixedUpdate()
    {


    }
}

