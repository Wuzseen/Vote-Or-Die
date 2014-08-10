using UnityEngine;
using System.Collections;

public class Moneybags : PlayerDecorator {
    public override bool GoalCompleted() {
        return decorated.GoalCompleted();
    }

    public override void GainMoney(int amount) {
        this.money += amount * 2;
    }
}
