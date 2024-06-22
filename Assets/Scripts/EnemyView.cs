using UnityEngine;
using UnityEngine.UI;

public class EnemyView : MonoBehaviour
{
    public Text healthText;

    public void UpdateUI(float health)
    {
        healthText.text = health.ToString();
    }
}
