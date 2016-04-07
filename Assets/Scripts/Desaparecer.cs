using UnityEngine;
using System.Collections;

public class Desaparecer : MonoBehaviour {

    // En el entorno se determina el numero deveces que debe ser pulsado el obstaculo para eliminarlo
    public int numVecesPulsacion; 

    void OnMouseDown() { 
        // IMPORTANTE -> todo objeto que use este script debe ser tagueado con Obstaculo
        if(this.gameObject.tag == "Obstaculo"){
            if (numVecesPulsacion != 1)
                numVecesPulsacion--;
            else
                Destroy(gameObject, 0f); // Destruye el objeto pulsado
        }
    }

}
