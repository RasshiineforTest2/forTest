using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float scale;
    float timeCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        scale = Mathf.Abs(Mathf.Sin(timeCount * 30)) * 2;
        transform.localScale += new Vector3(scale, scale, scale);
    }
}
