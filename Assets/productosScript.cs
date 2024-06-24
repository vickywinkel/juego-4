using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class productosScript : MonoBehaviour
{
    public GameObject[] objetos;
    public GameObject objetoActivadoARRIBA;
    public objetoScript producto;
    public Text txtPrecioArriba;
    public Text txtResultado;
    public Text txtPrecioD;
    public Text txtPrecioM;
    public Text txtPrecioI;
    public Vector3 coordenadasArriba = new Vector3(-9, 2, 5);
    public Vector3 coordenadasAbajoD = new Vector3(12,-4,10);
    public Vector3 coordenadasAbajoM = new Vector3(0,-4,10);
    public Vector3 coordenadasAbajoI = new Vector3(-10,-4,10);

    int valorDinero = 40;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objetos.Length; i++) //DESACTIVA TDS LOS OBJETOS AL PRINCIPIO
        {
            objetos[i].SetActive(false);
        }

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasArriba;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        txtPrecioArriba.text = ("$" + producto.precio);
        Debug.Log(producto.precio);

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasAbajoD;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        txtPrecioD.text = ("$" + producto.precio);
        Debug.Log(producto.precio);

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasAbajoM;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        txtPrecioM.text = ("$" + producto.precio);
        Debug.Log(producto.precio);

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasAbajoI;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        txtPrecioI.text = ("$" + producto.precio);
        Debug.Log (producto.precio);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void GenerarOperacion()
    {
        // Calcular el valor necesario para completar la operación
        int valorNecesario = valorDinero - producto.precio;

        //if(valorNecesario == //aca va uno de los pprecios del produc)
    }


    void GenerarRandom()
    {
        int azar = Random.Range(0, objetos.Length); 
        objetoActivadoARRIBA = objetos[azar];
        objetoActivadoARRIBA.SetActive(true);

    }
}