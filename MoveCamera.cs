using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public GameObject objetoBolinha;
	private Vector3 posicaoInicial;

	void Start () {

		posicaoInicial = transform.position - objetoBolinha.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = objetoBolinha.transform.position + posicaoInicial;

		//dale
	}
}
