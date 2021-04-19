using UnityEngine;

public class NewTestScript : MonoBehaviour {
    public int _pa_pa_carla = 1;

    public void Update()
    {
        if (true)
            Debug.Log("DirtyCall");
        else Debug.Log("DirtyCall");

         Debug.Log("papa");

         float ABOBA = 0f;
          _pa_pa_carla = _pa_pa_carla - _pa_pa_carla + _pa_pa_carla;
     }
}
