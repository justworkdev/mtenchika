using UnityEngine;
using System.Collections;
using Vuforia;
using System;

public class btnResult : MonoBehaviour {

	[SerializeField]
	int storeNo;

	GameObject cam;
	GameObject arCam;
	GameObject ar_char;
	GameObject imageTarget;

	// Use this for initialization
	void Awake () {
		cam = GameObject.Find ("Camera");
		arCam = GameObject.Find ("ARCamera");
		imageTarget = GameObject.Find (storeNo.ToString());
		ar_char = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				Debug.Log(obj.name);

				if (obj.name == gameObject.name) {
					//Application .LoadLevel ("result");
					//Vector3 target = new Vector3(ar_char.transform.position.x, cam.transform.position.y + 180.0f , cam.transform.position.z + 180);
					//ar_char.transform.LookAt(target);
					//imageTarget.transform.renderer(false);
					imageTarget.SetActive(false);

					//Renderer it = GameObject.Find ("319").GetComponent<Renderer>();
					//it.enabled = false;

					Vector3 preTarget = new Vector3(-0.05f,0,1);
					// プレハブを取得
					GameObject prefab = (GameObject)Resources.Load ("Prefabs/"+storeNo);
					// プレハブからインスタンスを生成
					Instantiate (prefab, preTarget, Quaternion.identity);

					GameObject resultMush = GameObject.Find (storeNo + "(Clone)");
					resultMush.transform.localScale = new Vector3(0.04f, 0.04f, 1);

					//カメラポジションを戻す。
					//Vector3 camTarget = new Vector3(0,0,0);
					//arCam.transform.position = camTarget;

					// 今のショップ番号を保存
					PlayerPrefs.SetInt("storeNo",storeNo);
					int time = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
						DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
					PlayerPrefs.SetInt(storeNo.ToString(),time);

					//Application .LoadLevel ("result");
				}
			}
		}
	}
}
