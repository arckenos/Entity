using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbujas : MonoBehaviour
{

    public GameObject[] burbujas;
    float tiempoEntre = 0.2f;
    float timer = 0;
    int index = 0;

    private void Start()
    {
        for(int i = 0; i < burbujas.Length; i++)
        {
            burbujas[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= tiempoEntre && index < burbujas.Length)
        {
            burbujas[index].SetActive(true);
            timer = 0;
            index++;
        }


    }
}
