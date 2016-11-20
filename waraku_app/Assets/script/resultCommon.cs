using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class resultCommon : MonoBehaviour {

	int storeNo;
	Text storeName;

	// Use this for initialization
	void Start () {
		storeNo = PlayerPrefs.GetInt("storeNo");
		storeName = GameObject.Find ("result_text_2").GetComponent<Text> ();

		switch (storeNo) {
		case 77:
			storeName.text = "スリーフォータイム様より";
			break;
		case 110:
			storeName.text = "パパブブレ様より";
			break;
		case 120:
			storeName.text = "タビオオム様より";
			break;
		case 126:
			storeName.text = "ビブリオテーク様より";
			break;
		case 223:
			storeName.text = "アカクラ様より";
			break;
		case 313:
			storeName.text = "サンリオビビティクス様より";
			break;
		case 312:
			storeName.text = "靴下屋様より";
			break;
		case 319:
			storeName.text = "フーチュラ様より";
			break;
		case 337:
			storeName.text = "ドクターシーラボ様より";
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
