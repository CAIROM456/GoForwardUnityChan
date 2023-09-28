using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CubeController : MonoBehaviour
{
	AudioSource audioSource;
	public AudioClip sound1;
	// �L���[�u�̈ړ����x
	private float speed = -12;

	// ���ňʒu
	private float deadLine = -10;

	// Start is called before the first frame update
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		// �L���[�u���ړ�������
		transform.Translate(this.speed * Time.deltaTime, 0, 0);

		// ��ʊO�ɏo����j������
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