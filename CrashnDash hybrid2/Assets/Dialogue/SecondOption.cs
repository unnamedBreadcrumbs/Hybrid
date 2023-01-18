using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondOption : MonoBehaviour
{
    public bool selected;
    public AudioClip dialogue;
    public AudioSource source;
    public GameObject currentscreen;
    public GameObject nextscreen;
    public bool audioplaying = false;

    public GameObject sprite;
    public SpriteRenderer sr;
    public Sprite select;
    public Sprite deselect;

    public NPC_AnimationKeyBinds MinerAnim;

    //public GameObject MinerAnim;

    void Start()
    {
        NPC_AnimationKeyBinds MinerAnim = gameObject.GetComponent<NPC_AnimationKeyBinds>();
    }
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0)
        {
            selected = true;

        }
        if (horizontalInput < 0)
        {
            selected = false;
        }


        if (selected == true)
        {
            sr.sprite = select;
        }
        if (selected == false)
        {
            sr.sprite = deselect;
        }




        if (selected == true && Input.GetButton("Fire1") && audioplaying == false)
        {
            //audio.clip = dialogue;
            //audio.Play();
            StartCoroutine(Play());
        }

    }

    IEnumerator Play()
    {
        sprite.SetActive(false);
        audioplaying = true;
        source.clip = dialogue;
        source.Play();
        MinerAnim.Move();
        yield return new WaitForSeconds(source.clip.length);
        MinerAnim.Stop();
        nextscreen.SetActive(true);
        currentscreen.SetActive(false);


    }

}
