using UnityEngine;
using System.Collections;

//Script que comprueba que el marcador esta siendo enfocado, si no, se envia un mensaje al usuario diciendo que lo enfoque..
public class EnfoqueMarcador : MonoBehaviour {
	private bool muestra_texto = false;
	public string texto;
	public GUISkin estilo;
	void OnGUI(){
		GUI.skin = estilo;
		if (muestra_texto) {
			GUI.skin.label.fontSize = (int) (Screen.width*5f)/50;
			GUI.contentColor = Color.green;
			GUI.skin.label.fontStyle = FontStyle.Bold;
			GUI.skin.label.alignment = TextAnchor.LowerCenter;
			GUI.Label(new Rect(0, Screen.height*0.10f, Screen.width, Screen.height*0.5f), texto); //45
			GUI.skin.label.alignment = TextAnchor.UpperLeft;
		}
	}

	public void marcadorEncontrado(){
		muestra_texto = false;
	}

	public void marcadorPerdido(){
		muestra_texto = true;
	}
}
