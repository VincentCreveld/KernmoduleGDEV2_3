using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : BehaviourBranch {

	public Sequence(params BehaviourBranch[] acs) {
		if(acs.Length > 0) {
			foreach(BehaviourBranch a in acs) {
				branchList.Add(a);
			}
		}
	}

	public override bool CheckActions(Blackboard b) {
		foreach(BehaviourBranch a in branchList) {
			if(!a.CheckActions(b))
				return false;
		}
		return true;
	}

	public override ActionState GetState() {
		throw new System.NotImplementedException();
	}
}
