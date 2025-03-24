using System;
using UnityEngine;

public class FruitsController : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem particleSystem;

    private GameObject particlesGO;

    [SerializeField]
    private float gravite;

    Vector3 fakeGravity;

    Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 fakeGravity = new Vector3(0, gravite, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity += fakeGravity * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sabre"))
        {
            particlesGO = Instantiate(particleSystem.gameObject, transform.position, transform.rotation);

            CompteurPointController.AjoutPoint();

            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Rigidbody>().useGravity = false;

            particleSystem.Play();

            Invoke("Delete", 1f);
        }
        if (other.gameObject.CompareTag("End"))
        {
            Destroy(particlesGO);
            Destroy(gameObject);
        }
    }

    void Delete()
    {
        Destroy(particlesGO);
        Destroy(gameObject);
    }
}
