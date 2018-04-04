using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Action {
	public Attack(Blackboard b) : base(b) {
	}

	public override bool CheckActions(Blackboard b) {
		throw new System.NotImplementedException();
	}

	public override ActionState GetState() {
		throw new System.NotImplementedException();
	}
}
