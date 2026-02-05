using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int points = 1;
    [SerializeField] private float rotateSpeed = 100f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        GameManager.Instance.AddCoins(points);
        Destroy(gameObject);
    }
}
