using UnityEngine;
using System.Collections;

public class BasicPlayer : Player {
    public override bool GoalCompleted() {
        foreach (Item i in this.inventory) {
            if (i.GetType() == typeof(Maguffin)) {
                return true;
            }
        }
        return false;
    }

    public override void GainMoney(int amount) {
        this.money += amount;
    }
}
