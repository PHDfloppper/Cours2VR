using System;
using System.Collections;
using UnityEngine;

public class FruitSpawnerController : MonoBehaviour
{

    [SerializeField]
    private GameObject[] fruitPositions;
    [SerializeField]
    private GameObject prefabFruit;
    [SerializeField]
    private float pointVictoire;
    [SerializeField]
    private float delaisFruits;
    void Start()
    {
        // Démarre la coroutine pour spawn un fruit toutes les 2 secondes
        StartCoroutine(SpawnFruitRoutine());
    }

    IEnumerator SpawnFruitRoutine()
    {
        while (CompteurPointController.points<pointVictoire) // Boucle infinie
        {
            Debug.Log("coroutine");
            SpawnFruit();
            yield return new WaitForSeconds(delaisFruits); // Attendre 2 secondes avant la prochaine instance
        }
    }

    void SpawnFruit()
    {
        if (fruitPositions.Length == 0 || prefabFruit == null)
        {
            Debug.LogWarning("Aucune position ou prefab assigné !");
            return;
        }
        Debug.Log("spawnFruit");
        int randomIndex = UnityEngine.Random.Range(0, 4);
        Vector3 spawnPosition = fruitPositions[randomIndex].transform.position;

        Instantiate(prefabFruit, spawnPosition, Quaternion.identity);
    }
}
