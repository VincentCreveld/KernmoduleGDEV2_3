using System.Collections.Generic;

public class BehaviourTree {

	protected Blackboard board;
	protected List<BehaviourTree> reference;

	public BehaviourTree(Blackboard b, params BehaviourTree[] branch) {
		foreach(BehaviourTree bt in branch) {
			reference.Add(bt);
		}
		board = b;
	}

	public virtual List<BehaviourTree> Act() {
		return null;
	}

	public virtual bool IsPossible() {
		return false;
	}
}
