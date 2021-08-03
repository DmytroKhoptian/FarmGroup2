using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI saveSheepText;
    [SerializeField] private TextMeshProUGUI dropSheepText;
    [SerializeField] private ScoreManager scoreManager;

    public void UpdateScore()
    {
        saveSheepText.text = scoreManager.SheepSaved.ToString();
        dropSheepText.text = scoreManager.SheepDropped.ToString();

        if(scoreManager.SheepDropped > scoreManager.SheepDroppedBeforeGameOver)
        {
            Debug.Log("GameOver");
        }
    }
}
