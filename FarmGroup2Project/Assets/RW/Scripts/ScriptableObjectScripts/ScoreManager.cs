using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObjects/NewScoreManager")]
public class ScoreManager : ScriptableObject
{
    [SerializeField] private int sheepSaved;
    [SerializeField] private int sheepDropped;
    [SerializeField] private int sheepDroppedBeforeGameOver;

    public int SheepSaved { get { return sheepSaved; } }
    public int SheepDropped { get { return sheepDropped; } }
    public int SheepDroppedBeforeGameOver { get { return sheepDroppedBeforeGameOver; } }

    private void OnEnable()
    {
        sheepSaved = 0;
        sheepDropped = 0;
    }

    public void AddSaveSheep()
    {
        sheepSaved++;
    }

    public void AddDropSheep()
    {
        sheepDropped++;
    }
}
