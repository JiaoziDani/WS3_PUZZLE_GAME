using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObjects/Enemy", order = 1)]
public class SOEnemy : ScriptableObject
{
    public Sprite art;
    public int topHealth;
    public int bottommHealth;
    public int leftHealth;
    public int rightHealth;
}
