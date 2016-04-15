using UnityEngine;
using System.Collections;

public class testMovement : MonoBehaviour {

	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Circuit"), "time", 15, "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.loop, "orienttopath", true, "lookahead", .1f));
	}
}
