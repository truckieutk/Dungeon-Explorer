﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIcon : MonoBehaviour
{

	public Sprite[] damageSprites;

	public GameObject effect;
	public float lifetime;

	private void Start()
	{
		Invoke("Destruction", lifetime);
	}

	public void Setup(int damage)
	{
		GetComponent<SpriteRenderer>().sprite = damageSprites[damage - 1];
	}

	void Destruction()
	{
		Instantiate(effect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
