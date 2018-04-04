using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : BehaviourTree {
	public Decorator(Blackboard b, params BehaviourTree[] branch) : base(b, branch) {
	}
}
