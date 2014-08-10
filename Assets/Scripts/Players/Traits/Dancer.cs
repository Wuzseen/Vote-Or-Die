using UnityEngine;
using System.Collections;

// Doesn't really do anything, the room will check the players--see if their type matches this. Effectively just a basic player
public class Dancer : PlayerDecorator {
    public override bool GoalCompleted() {
        return decorated.GoalCompleted();
    }

    public override void GainMoney(int amount) {
        decorated.GainMoney(amount);
    }
}
