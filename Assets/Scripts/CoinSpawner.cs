using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // The prefab that we want to instantiate:
    [SerializeField] private GameObject coinPrefab;

    // Update is called once per frame
    void Update()
    {
        // When player presses "Spacebar"...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ...spawn a coin!
            Instantiate(coinPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
