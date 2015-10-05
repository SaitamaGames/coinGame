using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// スコア管理
/// </summary>
public class Score : MonoBehaviour {
	Text text;
	static int score = 0;
	static int nextScore = 10;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = score.ToString()+"点";
	}

	public static void addScore()
	{
		score++;

		if( score > nextScore )
		{
			nextScore += 10;
			UnityChanCoin.UnityChanAnime();
		}

	}
}









