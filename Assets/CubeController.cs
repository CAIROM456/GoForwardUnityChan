using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CubeController : MonoBehaviour
{
	AudioSource audioSource;
	public AudioClip sound1;
	// キューブの移動速度
	private float speed = -12;

	// 消滅位置
	private float deadLine = -10;

	// Start is called before the first frame update
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		// キューブを移動させる
		transform.Translate(this.speed * Time.deltaTime, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine)
		{
			Destroy(gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (tag != "Player")
		{
			audioSource.PlayOneShot(sound1);
		}
	}
}
