using UnityEngine;
using System.Collections;

public class btnLink : MonoBehaviour {

	// Update is called once per frame
	public void OnClick () {
		switch (detailCommon.storeNo) {
		case 77:
			Application.OpenURL("http://www.tenchika.com/id/shop/three_four.php");
			break;
		case 110:
			Application.OpenURL("http://www.tenchika.com/id/shop/papabubble.php");
			break;
		case 120:
			Application.OpenURL("http://www.tenchika.com/id/shop/tabio.php");
			break;
		case 126:
			Application.OpenURL("http://www.tenchika.com/id/shop/bibliotheque.php");
			break;
		case 223:
			Application.OpenURL("http://www.tenchika.com/id/shop/akakura.php");
			break;
		case 313:
			Application.OpenURL("http://www.tenchika.com/id/shop/sanrio.php");
			break;
		case 312:
			Application.OpenURL("http://www.tenchika.com/id/shop/kutsushitaya.php");
			break;
		case 319:
			Application.OpenURL("http://www.tenchika.com/id/shop/futura.php");
			break;
		case 337:
			Application.OpenURL("http://www.tenchika.com/id/shop/cilabo.php");
			break;
		}
	}
}
