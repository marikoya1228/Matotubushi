using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour
{
    public GameObject PrefabTarget;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % 360 == 0)
        {
            float x = Random.Range(-2.0f, 2.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Vector3 pos = new Vector3(x, y, 0);

            Instantiate(PrefabTarget, pos, Quaternion.identity);
        }
    }
}
