using UnityEngine;

public class CompteurPointController : MonoBehaviour
{
    public static int points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AjoutPoint()
    {
        points += 1;
    }
}
