using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item")]
public class Item : ScriptableObject {

    public string m_name;
    [Range(0, 1)]
    public float m_dropChance;
   
}
