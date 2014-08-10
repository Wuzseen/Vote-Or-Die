using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
        if (this.canAfford(anItem)) {
            this.money -= anItem.Value;
            return true;
        }
        return false;
    }
    private bool canAfford(Item anItem) {
        return this.money >= anItem.Value;
    }

	public int money = 100000;
	private PhotonView photonView;
	
	// Use this for initialization
	void Awake () {
		photonView = this.GetComponent<PhotonView>();
		if(photonView.isMine) {
			localPlayer = this;
			Game.Instance.photonView.RPC("NewPlayer",PhotonTargets.All,null);
		}
	}

	// Decorated methods
	public abstract bool GoalCompleted();
	public abstract void GainMoney(int amount);
}
