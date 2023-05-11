using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyTarget", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyTarget()
    {
        Destroy(gameObject);
    }
}
