using UnityEngine;
using System.Collections;

/// <summary>
/// ギミックを動かすスクリプト
/// </summary>
public class GimmickMove : MonoBehaviour {

	float moveTime = 0;
	bool turn = false;
	const float TurnTime = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//押し出し
		if( turn == false )
		{
			moveTime += Time.deltaTime;

			if( moveTime >= TurnTime )
			{
				turn = true;
			}
		}
		//戻す
		else
		{
			moveTime -= Time.deltaTime;
			
			if( moveTime <= 0 )
			{
				turn = false;
			}
		}

		//位置を設定
		Vector3 point = transform.localPosition;
		point.z = 1.5f + moveTime;

		transform.localPosition = point;

	}



}
