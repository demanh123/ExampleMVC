using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyModel enemyModel;
    public EnemyView enemyView;
        
    void Start()
    {
        enemyModel = GetComponent<EnemyModel>();
        enemyView = GetComponent<EnemyView>();
    }

    void Update()
    {
        Transform newEnemyPosition = transform;
        newEnemyPosition.Translate(Vector3.left * enemyModel.speed * Time.deltaTime);
        enemyModel.PositionChange(newEnemyPosition.position);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "projectile")
        {
            Destroy(collision.gameObject);

            enemyModel.TakeDamage(10f);
            if (enemyModel.health <= 0)
            {
                Destroy(gameObject);
            }
            Transform newEnemyPosition = transform;
            newEnemyPosition.Translate(Vector3.right * enemyModel.backDistance);            
            enemyModel.PositionChange(newEnemyPosition.position);

            enemyView.UpdateUI(enemyModel.health);
        }        
        else if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
