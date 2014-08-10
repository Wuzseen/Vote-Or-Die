using UnityEngine;
using System.Collections;

public abstract class PlayerDecorator : Player {
    protected Player decorated;

    public PlayerDecorator() {
        this.decorated = null;
    }

    public PlayerDecorator(Player player) {
        this.decorated = player;
    }
}
