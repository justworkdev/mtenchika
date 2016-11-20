using UnityEngine;
using System.Collections;

public class goDetail : MonoBehaviour {

	// Update is called once per frame
	public void OnClick () {
		detailCommon.storeNo = PlayerPrefs.GetInt("storeNo");
		Application .LoadLevel ("details");
	}
}
