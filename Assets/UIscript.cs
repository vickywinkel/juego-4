using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    public objetoScript producto;
    public Text txtPrecio;
    // Start is called before the first frame update
    void Start()
    {
        producto = gameObject.GetComponent<objetoScript>();
        txtPrecio.text = ("$" + producto.precio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
