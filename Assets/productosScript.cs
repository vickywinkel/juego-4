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
        int precioDeArriba = producto.precio; 
        txtPrecioArriba.text = ("$" + producto.precio);
        Debug.Log(producto.precio);

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasAbajoD;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        int precioDeAbajoD = producto.precio;
        txtPrecioD.text = ("$" + producto.precio);
        Debug.Log(producto.precio);

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasAbajoM;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        int precioDeAbajoM = producto.precio;
        txtPrecioM.text = ("$" + producto.precio);
        Debug.Log(producto.precio);

        GenerarRandom();
        objetoActivadoARRIBA.transform.position = coordenadasAbajoI;
        producto = objetoActivadoARRIBA.GetComponent<objetoScript>();
        int precioDeAbajoI = producto.precio;
        txtPrecioI.text = ("$" + producto.precio);
        Debug.Log (producto.precio);

        int[] arrayPrecios = { precioDeAbajoD, precioDeAbajoI, precioDeAbajoM };
        int precioAzar = Random.Range(0, arrayPrecios.Length);

        int precioTotal = precioDeArriba + arrayPrecios[precioAzar];

        txtResultado.text = ("$" + precioTotal); 

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


    public void cambioColorD()
    {
        txtPrecioD.color = Color.red;
        txtPrecioM.color = Color.black;
        txtPrecioI.color = Color.black;
    }
    public void cambioColorM()
    {
        txtPrecioD.color = Color.black; 
        txtPrecioM.color = Color.red;
        txtPrecioI.color = Color.black;
    }
    public void cambioColorI()
    {
        txtPrecioD.color = Color.black; 
        txtPrecioM.color = Color.black;
        txtPrecioI.color = Color.red; 
    }


}