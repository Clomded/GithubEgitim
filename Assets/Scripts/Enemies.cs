using UnityEngine;

[CreateAssetMenu(fileName = "Enemies", menuName = "Scriptable Objects/Enemies")]
public class Enemies : ScriptableObject
{
    public Sprite sprite;
    public float speed;
    public Transform player;
}
