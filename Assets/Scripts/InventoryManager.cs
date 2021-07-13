using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject invetory;
    public GameObject[] slots;
    

    bool active = false;
    int slotIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        
        slots = GameObject.FindGameObjectsWithTag("Slot");
        invetory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            active = !active;
            if (!active)
            {
                for(int i = 0; i < slots.Length; i++)
                {
                    slots[i].GetComponent<SlotScript>().HideName();
                }
            }
            invetory.SetActive(active);
            
        }
    
    }

    public void AddObject(GameObject gO)
    {
        slots[slotIndex].GetComponent<SpriteRenderer>().sprite = gO.GetComponent<SpriteRenderer>().sprite;
        gO.transform.Find("Nombre").transform.parent = slots[slotIndex].transform;
        slots[slotIndex].GetComponent<SlotScript>().SetNombre(gO.GetComponent<Object>().GetNombre());

        
        slotIndex++;
    }

    
}
