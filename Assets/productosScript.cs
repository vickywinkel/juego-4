using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class productosScript : MonoBehaviour
{
    public GameObject[] objetos;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
