using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tags : MonoBehaviour
{

   

    public List<string> CatTags;
    public List<string> PintorTags;
    public List<string> FotografoTags;
    public List<string> PescadorTags;
    public List<string> AlienTags;
    public List<string> PezTags;

    public int pintorPoints = 4;
    public int catPoints = 3;
    public int pezPoints = 4;
    public int pescadorPoints = 4;
    public int fotografoPoints = 5;
    public int alienPoints = 3;
    int hogueraPoints = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SendTag(string tag)
    {
        if (PintorTags.Contains(tag))
        {
            pintorPoints--;
            if (pintorPoints == 0)
                SceneManager.LoadScene("PintoFinal"); 
        }
            

        if (CatTags.Contains(tag))
        {
            catPoints--;
            if (catPoints == 0)
                SceneManager.LoadScene("GatoFinal");
        }

        if (PescadorTags.Contains(tag))
        {
            pescadorPoints--;
            if (pescadorPoints == 0)
                SceneManager.LoadScene("PescadorFinal");
        }

        if (PezTags.Contains(tag))
        {
            pezPoints--;
            if (pezPoints == 0)
                SceneManager.LoadScene("PezFinal");
        }

        if (AlienTags.Contains(tag))
        {
            alienPoints--;
            if (alienPoints == 0)
                SceneManager.LoadScene("AlienFinal");
        }

        if (PintorTags.Contains(tag))
        {
            pintorPoints--;
            if (pintorPoints == 0)
                SceneManager.LoadScene("PintoFinal");
        }

        if (FotografoTags.Contains(tag))
        {
            fotografoPoints--;
            if (fotografoPoints == 0)
                SceneManager.LoadScene("FotografoFinal");
        }

        if (tag == "fuego") 
            hogueraPoints--;
        if(hogueraPoints == 0)
            SceneManager.LoadScene("FinalHoguera");
    }

}
