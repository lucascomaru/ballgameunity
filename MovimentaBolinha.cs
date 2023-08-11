using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentaBolinha : MonoBehaviour {

    private Rigidbody rb;
    public GameObject particulaItem;

    public Text textoPontos;
    public Text textoFinal;

    private int pontos;

    void Start () {
        rb = GetComponent<Rigidbody>();
        textoFinal.text = "";
        textoPontos.text = pontos.ToString(); 
		//haaan
    }

    void FixedUpdate () {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(move);
    }

    void OnTriggerEnter(Collider outro) {
        if (outro.gameObject.CompareTag("item")) {
            Instantiate(particulaItem, outro.gameObject.transform.position, Quaternion.identity);
            Destroy(outro.gameObject);
            MarcaPonto();
        }
    }

    void MarcaPonto() {
        pontos++;
        textoPontos.text = pontos.ToString(); 
        if (pontos == 5) {
            textoFinal.text = "Você venceu!";
        }
    }
}
