using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SheepProperty", menuName = "ScriptableObjects/newSheepProperty")]
public class SheepProperty : ScriptableObject
{
    

    [SerializeField] private string sheepName; 
    [SerializeField] private float speed;
    [SerializeField] private Material material;


    public string Name 
    {
        get
        {
            if(sheepName == "")
            {
                Debug.LogWarning("No Sheep Name");
                return "None Name";
            }
            else
            {
                return sheepName;
            }          
        }
        set
        {
            sheepName = value;
        }
    }





    public float Speed
    {
        get 
        {
            return speed;
        }
        // set
        //{
        //    speed = value;
        //}
    }

    // public Material Material { get { return material; } }
    public Material Material => material; // get сокращение

}
