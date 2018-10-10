﻿using System.Collections.Generic;
using UnityEngine;
using System;


public class Unit : MonoBehaviour
{
	public Profile profile;
	[NonSerialized]
	public Vector3Int tile_position;


	Board boardController;


	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
	}
   
	public void new_turn_update() {
		profile.UpdateTurnChange();
	}

	public void setBoardController(Board boardController) {
		this.boardController = boardController;
	}

	public void inflictDamage(int damages, Unit target) {
		target.receiveDamage(damages);
	}

	public void receiveDamage(int damage) {
		this.profile.health_points.value -= damage;
	}
    
}
