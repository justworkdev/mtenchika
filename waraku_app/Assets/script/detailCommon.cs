using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class detailCommon : MonoBehaviour {

	public static int storeNo = 77;

	Image title;
	Image detail;
	Text comment;

	Text coupon;
	Text couponConf;

	public static Hashtable couponStats;

	// Use this for initialization
	void Start () {
		couponStats = new Hashtable ();

		couponStats[77] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[110] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[120] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[126] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[223] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[312] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[313] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[319] = PlayerPrefs.HasKey(storeNo.ToString());
		couponStats[337] = PlayerPrefs.HasKey(storeNo.ToString());

		Debug.Log ("details::"+storeNo);

		coupon = GameObject.Find ("coupon_detail").GetComponent<Text> ();
		couponConf = GameObject.Find ("coupon_conf").GetComponent<Text> ();

		//GameObject pop = GameObject.Find ("pop");
		if ((bool)couponStats [storeNo] == false) {
			couponConf.text = "";
			coupon.text = "この店舗のクーポンはゲットしてません。";

			GameObject it = GameObject.Find ("btn_coupon");
			it.SetActive(false);

		} else {
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
		}


		title = GameObject.Find ("title").GetComponent<Image> ();
		title.sprite = Resources.Load("detail/"+storeNo+"_title", typeof(Sprite)) as Sprite;

		detail = GameObject.Find ("detail").GetComponent<Image> ();
		detail.sprite = Resources.Load("detail/"+storeNo+"_detail", typeof(Sprite)) as Sprite;

		comment = GameObject.Find ("detail_comment").GetComponent<Text> ();

		switch (storeNo) {
		case 77:
			comment.text = "他にはない手作り感が女の子の気持ちをくすぐるThree Four Time。誰でも心のどこかに持っているsweetな感覚を大切にしています。それでいておもしろさも忘れない。良い感じで「ゆるさ」があるブランドで す。アクセサリーに合わせて、服を選びたくなる...そんな気持ちにさせてくれるのがThree Four Timeです。";
			break;
		case 110:
			comment.text = "スペイン・バルセロナで発祥し世界18カ国に展開するアートキャンディショップ「パパブブレ」。飴職人がひとつひとつ丁寧に仕上げていくアートキャンディは、「かわいい！」と思わず声が出てしまうほどキュートです。";
			break;
		case 120:
			comment.text = "レディスソックスでお馴染の「靴下屋」の九州初の紳士靴下専門店。オーセンティックなラインナップを中心に、ドレスコレクション、カジュアルコレクション、スポーツ靴下からオーガニックコットン素材の靴下まで、トレンドのマストアイテムといった充実の商品構成で常時200アイテム以上をラインナップ。";
			break;
		case 126:
			comment.text = "Luxury,Casuple,Simple and Ageless 都会的で、トレンドを柔軟に取り入れ、自由にオシャレを楽しむ女性達に、ラグジュアリー&カジュアルな大人のスタイリングを提案します。";
			break;
		case 223:
			comment.text = "ヤングからミセスまで、幅広く商品を展開しております。イタリアブランド「kalliste」とのコラボによる「Ｋカリステ」をはじめ、アカクラオリジナル商品も多数取り揃えておりますので、ぜひごらんください！！";
			break;
		case 313:
			comment.text = "ティーン〜大人女子を意識したキャラクター・シーズン・ギフトのショップ。日本のカルチャーたくさんの『Kawaii！』を詰め込み、福岡の情報発信店舗を目指します。（SANRIO VIVITIXの店舗は九州では天神地下街店のみです）";
			break;
		case 312:
			comment.text = "「包まれて、暮らしたい」というコンセプトをもとに生まれた、靴下屋。まるで「第二の皮膚」のように靴下を履いていることを忘れてしまうような感覚をあなたの足にも。";
			break;
		case 319:
			comment.text = "機能的なツールと、ユーモア溢れるデスクトップ雑貨で、毎日のワークスタイルを、より楽しく、快適に。Futuraは、自分らしい働き方を応援する WORK-LIFESTYLE SHOP です。";
			break;
		case 337:
			comment.text = "【肌トラブルに悩む全ての人々を救う】ために。\n「一人でも多くの方の肌悩みを解決したい・・・」という想いから開発された皮膚の専門家ドクターシーラボのメディカルコスメ。現在も肌トラブルに悩むお客様のお声に常に耳を傾け、先端のサイエンスにより、すこやかな肌へサポートする商品を生み出すために、研究、開発を続けています。";
			break;
		}

	}
	
	// Update is called once per frame
	void Update () {
	}
}
