using UnityEngine;

public class EnemyModel : MonoBehaviour
{
    public float health = 100f;
    public Vector3 position;
    public float speed = 2f;
    public float backDistance = 1f;

    private void Start()
    {
        position = transform.position;
    }
    public void PositionChange(Vector3 newEnemyPosition)
    {
        position = newEnemyPosition;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
