using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sequence : BehaviourTree {

	public List<BehaviourTree> branches;

	public Sequence(Blackboard b, params BehaviourTree[] bt) : base(b, bt) {
		branches = new List<BehaviourTree>();
		foreach(BehaviourTree be in bt) {
			branches.Add(be);
		}
		board = b;
	}

	public List<BehaviourTree> CheckChildren() {
		foreach(BehaviourTree b in branches) {
			if(!b.IsPossible())
				return null;
		}
		return DoActions();
	}

	public override List<BehaviourTree> Act() {
		return CheckChildren();
	}

	private List<BehaviourTree> DoActions() {
		//Invulling
		List<BehaviourTree> temp = new List<BehaviourTree>();
		foreach(BehaviourTree b in branches) {
			foreach(BehaviourTree be in b.Act()) {
				temp.Add(be);
			}
		}
		return temp;
	}

}
