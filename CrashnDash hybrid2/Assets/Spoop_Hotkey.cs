using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoop_Hotkey : MonoBehaviour
{
    public Animator Spoopy;
    public float AnimationCount;

    // Start is called before the first frame update
    void Start()
    {
        Spoopy.GetComponent<Animator>();
        AnimationCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            AnimationCount = 1;
        }

        Spoopy.SetFloat("Counter", AnimationCount);
    }
}
