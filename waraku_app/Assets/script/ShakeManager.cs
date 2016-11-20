using System;
using UnityEngine;
using System.Collections;

/// <summary>
/// オブジェクトに揺れるアニメーションを付与するクラス
/// </summary>
public class ShakeManager : MonoBehaviour {

	/// <summary>
	/// オブジェクトを振るアニメーション実行処理
	/// </summary>
	/// <returns>The anime.</returns>
	/// <param name="target">揺らしたいオブジェクト</param>
	/// <param name="shakeTimes">揺らす回数 何も指定しない場合は無限に揺れる</param>
	/// <param name="shakeInterval">傾く間隔</param>
	/// <param name="nextAnimeInterval">次の揺れるアニメーションまでの間隔</param>
	/// <param name="callBack">全てのアニメーションが終わった後に行いたい処理(shakeTimesが-1の場合は実行されない)</param>
	public static IEnumerator RunAnime(Transform target,int shakeTimes = -1,float shakeInterval = 0.3f,float nextAnimeInterval = 1,Action callBack = null)
	{
		int shakeCnt = shakeTimes;
		while(shakeCnt > 0)
		{
			target.Rotate(new Vector3(0,0,15));
			yield return new WaitForSeconds(shakeInterval);

			target.Rotate(new Vector3(0,0,-15));
			yield return new WaitForSeconds(shakeInterval);

			target.Rotate(new Vector3(0,0,-15));
			yield return new WaitForSeconds(shakeInterval);

			target.Rotate(new Vector3(0,0,15));
			yield return new WaitForSeconds(nextAnimeInterval);

			shakeCnt --;
		}

		// アニメーション完了後に行いたい処理が指定されている場合実行
		if(callBack != null)
		{
			callBack();
		}
	}
}