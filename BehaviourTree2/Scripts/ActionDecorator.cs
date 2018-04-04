using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionDecorator : Action {
	private Action reference;
	//public ActionDecorator(Action b) {
	//	reference = b;
	//}
	public virtual void Act() {

	}
}
