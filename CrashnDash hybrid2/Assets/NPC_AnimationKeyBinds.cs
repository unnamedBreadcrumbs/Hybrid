using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_AnimationKeyBinds : MonoBehaviour
{

    public Animator NPC;
    public Animator Mouth;
    public float AnimationCount;
    public float MouthCount;

    // Start is called before the first frame update
    void Start()
    {
        NPC.GetComponent<Animator>();
        Mouth.GetComponent<Animator>();

        AnimationCount = 0;
        MouthCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            AnimationCount = 1;
        }

        if (Input.GetKeyDown("2"))
        {
            AnimationCount = 0;
        }

        if (Input.GetKeyDown("3"))
        {
            MouthCount = 1;
        }

        if (Input.GetKeyDown("4"))
        {
            MouthCount = 0;
        }

        Mouth.SetFloat("MouthCounter", MouthCount);
        NPC.SetFloat("AnimatorCounter", AnimationCount);
    }
    public void Move()
    {
        MouthCount = 1;
        AnimationCount = 1;
    }

    public void Stop()
    {
        MouthCount = 0;
        AnimationCount = 0;
    }
}
