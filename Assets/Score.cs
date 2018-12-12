using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

	void Update ()
	{
	    scoreText.text = Convert.ToInt64(player.position.z).ToString();
	}
}
