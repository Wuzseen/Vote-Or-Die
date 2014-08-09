using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Basic storage of actions, executes something, plays an audio with it, etc. useful for networking...
// Extend as needed
// Might need to interface with an audio bank class so that we send audio over the network just as IDs or something
public abstract class GameAction {
	protected List<AudioClip> audio;
	public List<AudioClip> AudioClips {
		get { return audio; }
		set { audio = value; }
	}

	public GameAction() {
		this.audio = new List<AudioClip>();
	}

	public AudioClip RandomClip() {
		return audio[Random.Range(0,audio.Count)];
	}

	public abstract void PlayAction();
	public abstract bool Undoable();
	public virtual void UndoAction() {
		if(Undoable() == false) {
			return;
		}
	}
}
