using UnityEngine;
using System.Collections;

public class btnDetail : MonoBehaviour {

	// Update is called once per frame
	public void OnClick (int storeNo) {
		detailCommon.storeNo = storeNo;
		Application .LoadLevel ("details");
	}
}
