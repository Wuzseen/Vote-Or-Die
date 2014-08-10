using UnityEngine;
using System.Collections;

public class Millionaire : PlayerDecorator {
    public override bool GoalCompleted() {
        if (this.money >= 1000000) {
            return true;
        }
        return decorated.GoalCompleted();
    }

    public override void GainMoney(int amount) {
        decorated.GainMoney(amount);
    }
}
