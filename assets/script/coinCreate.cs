using UnityEngine;
using System.Collections;

/// <summary>
/// コインの生成
/// </summary>
public class coinCreate : MonoBehaviour {


	public GameObject originalCoin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if( Input.GetMouseButtonDown(0))
		{
			
			//多少ランダムのが面白い
			Vector3 point = new Vector3(0,
			                            6+Random.Range(0,2.0f),Random.Range(1.0f,3.0f));
			
			//マウスカーソルからRay放射
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			//z=100までにオブジェクトがあるか
			if(Physics.Raycast(ray, out hit,100))
			{
				//オブジェクトがなければ終了
				if( hit.collider.gameObject == null ) return;
				
				
				//if( hit.collider.gameObject.name != "Wall" ) return;
				
				//RaycastHitが衝突した座標を取得
				Vector3 v = hit.point;
				if( hit.point.y <= 0 )
				{
					return;
				}
				//えいきょうがあるのはxのみ
				point.x = v.x;
			}else
			{
				return;
			}
			point.x += Random.Range(0.5f,-0.5f);
			GameObject obj = (GameObject)Instantiate( originalCoin);
			
			//座標をセット
			obj.transform.localPosition = point;
			
		}
		
		
	}
}
