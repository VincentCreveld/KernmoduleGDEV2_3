using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BehaviourBranch {
	//This class exists to keep the behaviour tree storage as anonymous as possible
	protected ActionState currentState = ActionState.running;
	public abstract ActionState GetState();

	protected List<BehaviourBranch> branchList;
	protected List<Action> actions;

	public virtual List<Action> GetList(Blackboard b) {
		if(CheckActions(b))
			return actions;
		else
			return null;
	}

	public virtual bool IsLeaf() {
		return branchList.Count <= 0 ? true : false;
	}

	public abstract bool CheckActions(Blackboard b);
}
