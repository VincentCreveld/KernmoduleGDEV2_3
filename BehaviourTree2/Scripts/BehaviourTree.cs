using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree {
	private Action currentAction;
	private Selector selector;
	private List<Action> actions;
	private List<Sequence> sequences;
	private List<Selector> selectors;

	public BehaviourTree(Selector s) {
		selector = s;
	}

	public void Update() {
		if(currentAction == null) {
			CheckTree();
		}
		else {
			currentAction.DoAction();
		}
	}

	private void CheckTree() {
		//Checks tree

		//Gets list of all actions to be exeuted

		//Set queue to list

		//queue function NextAction()
	}
}

public enum ActionState {
	running, succes, failure
}
