using UnityEngine;

public class Bruh : MonoBehaviour
{
    public int Bruh1 = 0;
    public long Bruh2 = 0;
	private bool Bruh3_poshel_nosit_jashchiki = true;

    private void Update()
    {
        Debug.Log("Bruh");
		if (Bruh3_poshel_nosit_jashchiki == true) Debug.Log("Vito Scaletta любит таскать ящики, получать шиш и ломать грузовик.");
    }
}