using UnityEngine;
using System.Collections;

public class ScreenFader : MonoBehaviour {

	Animator anim;
	bool isFading = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public IEnumerator FadeToClear (){
		isFading = true;
		anim.SetTrigger ("FadeIn");

		//This function will not return until this isFading is set back to false
		while (isFading)
			yield return null;
	}

	public IEnumerator FadeToBlack(){
		isFading = true;
		anim.SetTrigger ("FadeOut");

		//This function will not return until this isFading is set back to false
		while (isFading)
			yield return null;
	}

	void AnimationComplete(){
		isFading = false;
	}
}
