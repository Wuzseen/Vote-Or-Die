﻿using UnityEngine;using System.Collections;public class KittyPetter : PlayerDecorator {    public override bool GoalCompleted() {        return decorated.GoalCompleted() || this.PettedKitty;    }    public override void GainMoney(int amount) {        decorated.GainMoney(amount);    }}