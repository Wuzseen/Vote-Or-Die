using UnityEngine;
using System.Collections;

public class EnvironmentFactory {
	public static GameEnvironment CreateEnvironment(RoomTypes roomType) {
		if(roomType == RoomTypes.Disco) {
			// return a disco environment
		} else if (roomType == RoomTypes.Empty) {

		} else if (roomType == RoomTypes.NarniaPort) {

		}
	}
}
