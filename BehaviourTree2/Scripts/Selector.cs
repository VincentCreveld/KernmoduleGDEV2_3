using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : BehaviourBranch {
	

	public Selector(params BehaviourBranch[] acs) {
		if(acs.Length > 0) {
			foreach(BehaviourBranch a in acs) {
				branchList.Add(a);
			}
		}
	}

	public override bool CheckActions(Blackboard b) {
		actions = new List<Action>();
		foreach(Action a in actions) {
			if(a.CheckActions(b))
				actions.Add(a);
		}

		if(actions.Count > 0)
			return true;
		else
			return false;
	}

	public override ActionState GetState() {
		throw new System.NotImplementedException();
	}
}


