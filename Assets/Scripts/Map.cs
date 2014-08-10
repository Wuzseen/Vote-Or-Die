using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public struct GridLocation {
	public int x;
	public int y;
}

public class Map {
	private Dictionary<GameEnvironment,GridLocation> environmentDict;

	public GameEnvironment[,] locations;
	private int width, height;
	public int Width {
		get { return width; }
	}
	public int Height {
		get { return height; }
	}

	public Map(int x, int y) {
		this.locations = new GameEnvironment[x,y];
	}

	public void AddRandomEnvironment() {
		Array vals = Enum.GetValues(typeof(RoomTypes));
		for(int i = 0; i < this.width; i++) {
			for(int z = 0; z < this.height; z++) {
				if(locations[i,z] == null) {
					RoomTypes type = (RoomTypes)vals.GetValue(UnityEngine.Random.Range(0,vals.Length));
					locations[i,z] = EnvironmentFactory.CreateEnvironment(type);
				}
			}
		}
	}
}