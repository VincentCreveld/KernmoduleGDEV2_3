using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Selector : BehaviourTree {

	[SerializeField]
	public List<BehaviourTree> branches;

	public Selector(Blackboard b, params BehaviourTree[] bt) : base(b, bt) {

	}

	public override List<BehaviourTree> Act() {
		return base.Act();
	}

}
