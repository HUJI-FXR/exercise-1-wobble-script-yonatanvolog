using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    public float positionFrequencyX = 1.231f;
    public float positionFrequencyY = Mathf.PI;
    public float positionFrequencyZ = 4.0f;

    public float scaleFrequencyX = 0.7f;
    public float scaleFrequencyY = 1.5f;
    public float scaleFrequencyZ = 2.2f;

    public float rotationFrequencyX = 1.8f;
    public float rotationFrequencyY = 0.9f;
    public float rotationFrequencyZ = 3.5f;

    public float massFrequency = 1.2f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.localPosition = new Vector3(
            Mathf.Sin(positionFrequencyX * Time.time),
            Mathf.Sin(positionFrequencyY * Time.time),
            Mathf.Sin(positionFrequencyZ * Time.time)
        );

        transform.localScale = new Vector3(
            1 + Mathf.Sin(scaleFrequencyX * Time.time) * 0.2f,
            1 + Mathf.Sin(scaleFrequencyY * Time.time) * 0.2f,
            1 + Mathf.Sin(scaleFrequencyZ * Time.time) * 0.2f
        );

        transform.Rotate(
            Mathf.Sin(rotationFrequencyX * Time.time),
            Mathf.Sin(rotationFrequencyY * Time.time),
            Mathf.Sin(rotationFrequencyZ * Time.time)
        );

        if (rb != null)
        {
            rb.mass = 1 + Mathf.Sin(massFrequency * Time.time) * 0.5f;
        }
    }
}