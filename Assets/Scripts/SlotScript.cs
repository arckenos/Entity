using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    public GameObject nombre;

    // Start is called before the first frame update
    void Start()
    {
        if (nombre != null)
            nombre.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

  

    }

    private void OnMouseEnter()
    {
        if(nombre != null)
            nombre.SetActive(true);
    }

    private void OnMouseExit()
    {
        if (nombre != null)
            nombre.SetActive(false);
    }

    public void HideName()
    {
        if (nombre != null)
            nombre.SetActive(false);
    }

    public void SetNombre(GameObject nombre)
    {
        this.nombre = nombre;
        Vector3 pos = new Vector3(0, 1, 10);
        nombre.transform.localPosition = pos;
    }
}
