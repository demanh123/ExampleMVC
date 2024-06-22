using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float speed = 10f;
    public float disappear_Time;

    private void Start()
    {
        Invoke("DestroyProjectile", disappear_Time);
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

}