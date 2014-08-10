using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public enum RoomTypes {
	SacrificalPit,
	Empty,
	NarniaPort,
	Disco,
	SciFi
}

public abstract class GameEnvironment {
	public List<Interactable> interactableObjects;

	public abstract int InteractableSlots();
	public abstract bool HasTreasure();
}