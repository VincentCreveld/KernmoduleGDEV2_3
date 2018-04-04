using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

	private Blackboard board;
	private Action currentAction;
	private Queue<Action> actionBuffer;
	protected BehaviourTree root;
	protected List<BehaviourTree> completeTree;

	private void Awake() {
		actionBuffer = new Queue<Action>();
		board = new Blackboard();
		root = new BehaviourTree(board, null);
		completeTree = new List<BehaviourTree>();
	}

	private void GetNewAction() {
		if(actionBuffer.Count > 0) {
			currentAction = actionBuffer.Dequeue();
			return;
		}
		foreach(BehaviourTree item in root.Act()) {
			actionBuffer.Enqueue(item as Action);
		}
	}


}
