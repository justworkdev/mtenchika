using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class couponCommon : MonoBehaviour {

	int storeNo;
	Image title;
	Text storeName;
	Text coupon;

	// Use this for initialization
	void Start () {
		storeNo = detailCommon.storeNo;

		title = GameObject.Find ("logo").GetComponent<Image> ();
		title.sprite = Resources.Load("detail/"+storeNo+"_title", typeof(Sprite)) as Sprite;

		storeName = GameObject.Find ("storeName").GetComponent<Text> ();

		switch (storeNo) {
		case 77:
			storeName.text = "スリーフォータイム様のクーポンになります。";
			break;
		case 110:
			storeName.text = "パパブブレ様のクーポンになります。";
			break;
		case 120:
			storeName.text = "タビオオム様のクーポンになります。";
			break;
		case 126:
			storeName.text = "ビブリオテーク様のクーポンになります。";
			break;
		case 223:
			storeName.text = "アカクラ様のクーポンになります。";
			break;
		case 313:
			storeName.text = "サンリオビビティクス様のクーポンになります。";
			break;
		case 312:
			storeName.text = "靴下屋様のクーポンになります。";
			break;
		case 319:
			storeName.text = "フーチュラ様のクーポンになります。";
			break;
		case 337:
			storeName.text = "ドクターシーラボ様のクーポンになります。";
			break;
		}


		coupon = GameObject.Find ("coupon").GetComponent<Text> ();
		switch (storeNo) {
		case 77:
			coupon.text = "全品10％OFF!!";
			break;
		case 110:
			coupon.text = "商品お買い上げの方へ先着でノベルティプレゼント";
			break;
		case 120:
			coupon.text = "全品10％OFF!!";
			break;
		case 126:
			coupon.text = "全品10％OFF!!";
			break;
		case 223:
			coupon.text = "全品10％OFF!!";
			break;
		case 313:
			coupon.text = "商品お買い上げの方へ先着でノベルティプレゼント";
			break;
		case 312:
			coupon.text = "カラータイツ10％OFF!!";
			break;
		case 319:
			coupon.text = "全品10％OFF!!";
			break;
		case 337:
			coupon.text = "スキンケアサンプルプレゼント！（先着50名）";
			break;
		}

		if (PlayerPrefs.HasKey ("read"+storeNo.ToString ())) {
			coupon.text = "クーポンは使用済みです。";
		}

		PlayerPrefs.SetInt("read"+storeNo.ToString (),1);
	}

}
