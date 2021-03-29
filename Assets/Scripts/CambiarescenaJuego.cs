using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarescenaJuego : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    void OntriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void CambiarEscena(string nombre)
    {

    }
}
