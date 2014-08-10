using UnityEngine;
using System.Collections;

public class NarniaTraveler : PlayerDecorator {
    public override bool GoalCompleted() {
        return decorated.GoalCompleted() || this.InNarnia();
    }

    public override void GainMoney(int amount) {
        decorated.GainMoney(amount);
    }
}
