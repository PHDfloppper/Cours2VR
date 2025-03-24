using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_TextMeshPro;

    private int pointsUI = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(pointsUI < CompteurPointController.points)
        {
           pointsUI = CompteurPointController.points;
            m_TextMeshPro.text = pointsUI.ToString();
        } 
    }
}
