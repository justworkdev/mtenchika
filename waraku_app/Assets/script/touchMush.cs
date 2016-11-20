using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touchMush : MonoBehaviour {

	private Renderer hukidashi;
	private Renderer serihu;

	private bool isTouch;
	TextMesh serihuText;

	// Use this for initialization
	void Start () {
		hukidashi = GameObject.Find ("00350_5").GetComponent<Renderer>();
		serihu = GameObject.Find ("text_serihu").GetComponent<Renderer>();
		serihuText = (TextMesh)GameObject.Find ("text_serihu").GetComponent(typeof(TextMesh));

		hukidashi.enabled = false;
		serihu.enabled = false;
		isTouch = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (isTouch) {
			return;
		}

		if (Input.GetMouseButtonDown (0)) {
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				Debug.Log(obj.name);

				if (obj.name == gameObject.name) {
					isTouch = true;
					StartCoroutine(ShakeManager.RunAnime(gameObject.transform,3,0.1f,0.5f,delegate 
						{
							hukidashi.enabled = true;
							serihu.enabled = true;

							string serihus = "Bon journee";

							switch(Random.Range(0, 4)){
							case 0:
								serihus = "トレビア～ン\n何かいいことが\nありそうですね";
								break;
							case 1:
								serihus = "たまにはゆっくり\n歩いてみるのも\nいいですね";
								break;
							case 2:
								serihus = "今日は何やら催しが\nお得があるかも\nしれませんね";
								break;
							case 3:
								serihus = "Bon journee";
								break;
							}
							serihuText.text = serihus;

							Invoke("removeHukidshi", 5.0f);
						})
					);

				}
			}
		}
	}

	void removeHukidshi(){
		hukidashi.enabled = false;
		serihu.enabled = false;
		isTouch = false;
	}
}
