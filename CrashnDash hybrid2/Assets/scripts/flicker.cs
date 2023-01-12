using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    public Light Kampvuur;
    float MinTime = 0.01f;
    float MaxTime = 0.5f;

    float MinTens = 4f;
    float MaxTens = 6f;

    //Color32 ColourMin = new Color32(255, 108, 0, 255);
    //Color32 ColourMax = new Color32(255, 47, 0, 255);
    float ColMin = 0.05f;
    float ColMax = 0.1f;





    // Start is called before the first frame update
    void Start()
    {
        Kampvuur.GetComponent<Light>();
        StartCoroutine(LightUpdate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LightUpdate()
    {
        Kampvuur.intensity = Random.Range(MinTens, MaxTens);
        Kampvuur.color = Random.ColorHSV(ColMin, ColMax, 1f, 1f, 1f, 1f, 1f, 1f);

        yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));

        Kampvuur.intensity = Random.Range(MinTens, MaxTens);
        Kampvuur.color = Random.ColorHSV(ColMin, ColMax, 1f, 1f, 1f, 1f, 1f, 1f);

        yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));

        Kampvuur.intensity = Random.Range(MinTens, MaxTens);
        Kampvuur.color = Random.ColorHSV(ColMin, ColMax, 1f, 1f, 1f, 1f, 1f, 1f);

        yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));

        Kampvuur.intensity = Random.Range(MinTens, MaxTens);
        Kampvuur.color = Random.ColorHSV(ColMin, ColMax, 1f, 1f, 1f, 1f, 1f, 1f);

        yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));
        StartCoroutine(LightUpdate());
    }
}
