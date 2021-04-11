using UnityEngine;

public class NewTestScript : MonoBehaviour
{
    public void Update()
    {
        if (true)
            Debug.Log("DirtyCall");
        else Debug.Log("DirtyCall");

        Debug.Log("Допустим");
    }
}
