using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public string accion;
    public float increase = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Debug.Log("Xddd");
        transform.localScale += new Vector3(increase, increase);

    }


    private void OnMouseDown()
    {
        Debug.Log(accion);
        transform.GetComponentInParent<Object>().ButtonPressed(accion);
    }

    private void OnMouseExit()
    {
        transform.localScale -= new Vector3(increase, increase);
    }

}
