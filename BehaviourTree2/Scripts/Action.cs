using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : BehaviourBranch {
	//Checks if action is possible
	private Blackboard blackboard;

	public Action(Blackboard b) {
		blackboard = b;
	}
	public virtual void DoAction() {

	}

	public override List<Action> GetList(Blackboard b) {
		List<Action> temp = new List<Action>();
		temp.Add(this);
		return temp;
	}
}
