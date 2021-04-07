using UnityEngine;

public class Bruh : MonoBehaviour
{
    public int Bruh1 = (int)1 ^ (int)(long)(int).123456789 >> (int)20;
    public long Bruh2 = (long)1 ^ (long)(int)(long).123456789 >> (int)20;

    private void Update()
    {
        Debug.Log("Bruh");
    }
}