using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public GameObject projectilePrefab;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
