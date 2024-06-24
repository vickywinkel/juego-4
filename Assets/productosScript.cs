using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class productosScript : MonoBehaviour
{
    public GameObject[] objetos;
    public GameObject objetoActivado;
    public objetoScript producto;
    public Text txtPrecio;
    public Vector3 coordentadas = new Vector3(-9, 2, 5);


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
        int azar = Random.Range(0, objetos.Length);
        objetoActivado = objetos[azar];
        objetoActivado.SetActive(true);
        objetoActivado.transform.position = coordentadas;

        producto = objetoActivado.GetComponent<objetoScript>();
        txtPrecio.text = ("$" + producto.precio);
        Debug.Log (producto.precio);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
