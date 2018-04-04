using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : Action {
	public Idle(Blackboard b) : base(b) {
	}

	public override bool CheckActions(Blackboard b) {
		throw new System.NotImplementedException();
	}

	public override ActionState GetState() {
		throw new System.NotImplementedException();
	}
}
