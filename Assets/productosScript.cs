using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class productosScript : MonoBehaviour
{
    public GameObject[] objetos;
    public GameObject objetoActivado;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
