using UnityEngine;
using System.Collections;

/// <summary>
/// コインの消失
/// </summary>
public class deadCoin : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
		//衝突で呼ばれます
		//if( collision.gameObject.name == "Coin" )
		{
			Score.addScore();
			Destroy(  collision.gameObject);
		}
	}


}
