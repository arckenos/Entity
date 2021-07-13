using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{

    public GameObject opVer;
    public GameObject opQuemar;
    public GameObject opTomar;
    public GameObject nombre;
    public float alturaNombre;
    public float tiempoVer = 3f;
    public GameObject vista;
    public GameObject fuego;
    public GameObject scripter;
    GameObject cam;
    Rect namePosition;

    private void Awake()
    {
        opVer.SetActive(false);
        opQuemar.SetActive(false);
        opTomar.SetActive(false);
        nombre.SetActive(false);
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        vista.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = Camera.main.WorldToScreenPoint(transform.position);
        scripter = GameObject.FindGameObjectWithTag("Scripter");
        namePosition = new Rect(pos.x,pos.y, 100, 10);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            nombre.SetActive(true);
            opVer.SetActive(true);
            opQuemar.SetActive(true);
            opTomar.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        opVer.SetActive(false);
        opQuemar.SetActive(false);
        opTomar.SetActive(false);
        nombre.SetActive(false);

    }


    public void ButtonPressed(string button)
    {
        if (button == "tomar")
        {
            GameObject.FindGameObjectWithTag("Scripter").GetComponent<InventoryManager>().AddObject(gameObject);
            scripter.GetComponent<Tags>().SendTag(gameObject.tag);
            Destroy(gameObject);
        }
        if(button == "ver")
        {
            StartCoroutine(MostrarVista());

        }
        if(button == "quemar")
        {
            GameObject go = Instantiate(fuego);
            scripter.GetComponent<Tags>().SendTag(gameObject.tag);
            go.transform.position = transform.position;
            Destroy(gameObject);
            
        }

    }

    public GameObject GetNombre()
    {
        return nombre;
    }

    IEnumerator MostrarVista()
    {
        
        vista.SetActive(true);
        yield return new WaitForSeconds(tiempoVer);
        vista.SetActive(false);
        Debug.Log("xD2");
    }
}
