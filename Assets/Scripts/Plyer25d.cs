using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyer25d : MonoBehaviour
{
    public float spped = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y);

        transform.Translate(direction * spped * Time.deltaTime);
    }
}
