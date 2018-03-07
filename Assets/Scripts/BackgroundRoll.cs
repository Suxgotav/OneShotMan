using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRoll : MonoBehaviour {
	float larguraTela;
	float alturaTela;
	// Use this for initialization
	void Start () {
		SpriteRenderer grafico = GetComponent<SpriteRenderer>();

		float larguraImagem = grafico.sprite.bounds.size.x;
		float alturaImagem = grafico.sprite.bounds.size.y;

		alturaTela = Camera.main.orthographicSize * 2f;

		larguraTela = alturaTela/Screen.height*Screen.width;		

		Vector2 novaEscala = transform.localScale;
		novaEscala.x = larguraTela/larguraImagem + 0.25f;
		novaEscala.y = alturaTela/alturaImagem;
		transform.localScale = novaEscala;

		if(this.name =="Fundo (1)"){
			transform.position = new Vector2(larguraTela,0f);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(-3,0);

	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= -larguraTela){
			transform.position = new Vector2(larguraTela,0);
		}
		
	}
}
