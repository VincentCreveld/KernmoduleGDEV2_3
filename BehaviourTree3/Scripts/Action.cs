using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionState { running, failure, success}

[System.Serializable]
public abstract class Action : BehaviourTree {
	public Action(Blackboard b, params BehaviourTree[] bt) : base(b, bt) {
	}
	public override bool IsPossible() {
		return false;
	}
	public override List<BehaviourTree> Act() {
		List<BehaviourTree> b = new List<BehaviourTree>();
		b.Add(this);
		return b;
	}
}
