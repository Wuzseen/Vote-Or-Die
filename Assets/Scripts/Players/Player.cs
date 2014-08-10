using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct GridLocation {
    public int x;
    public int y;
}

// Decorator pattern base class
public abstract class Player : MonoBehaviour {
	public static Player localPlayer;
    protected List<Item> inventory;

    public List<Item> Inventory {
        get { return inventory; }
    }
    public void AddItem(Item anItem) {
        this.inventory.Add(anItem);
    }
    public bool PurchaseItem(Item anItem) {
        if (this.CanAfford(anItem)) {
            this.money -= anItem.Value;
            return true;
        }
        return false;
    }
    public bool CanAfford(Item anItem) {
        return this.money >= anItem.Value;
    }

	protected int money = 100000;
    public int Money {
        get { return money; }
    }

    protected bool pettedKitty = false;
    public bool PettedKitty {
        get { return pettedKitty; }
        set { pettedKitty = value; }
    }

    private int locationsVisited = 0;
    public int LocationsVisited {
        get { return locationsVisited; }
        set { locationsVisited = value; }
    }
    public void VisitedLocation() {
        locationsVisited++;
    }

    private GridLocation location;
    public GridLocation Location {
        get { return location; }
        set { this.location = value; }
    }
	private PhotonView photonView;
	
	// Use this for initialization
	void Awake () {
		photonView = this.GetComponent<PhotonView>();
		if(photonView.isMine) {
			localPlayer = this;
			Game.Instance.photonView.RPC("NewPlayer",PhotonTargets.All,null);
		}
	}

    private int wonVotes = 0;
    public int WonVotes {
        get { return wonVotes; }
    }
    public void WinVote() {
        wonVotes++;
    }

    // Narnia is -1, -1
    public void SailToNarnia() {
        this.location.x = -1;
        this.location.y = -1;
    }

    public bool InNarnia() {
        return this.location.x == -1 && this.location.y == -1;
    }

	// Decorated methods
	public abstract bool GoalCompleted();
	public abstract void GainMoney(int amount);
}
