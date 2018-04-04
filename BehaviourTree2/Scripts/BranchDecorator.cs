using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BranchDecorator : BehaviourBranch {
	private BehaviourBranch reference;
	public BranchDecorator(BehaviourBranch b) {
		reference = b;
	}
	public virtual void Act() {

	}
}
