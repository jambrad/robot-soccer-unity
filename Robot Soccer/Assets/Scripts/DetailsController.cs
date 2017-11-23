using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsController : MonoBehaviour {

	CanvasGroup Canvas;
	Text TitleText, CreationText, ModifiedText, DescriptionText;
	// Use this for initialization
	void Start () {
		Canvas = GetComponent<CanvasGroup> ();
		TitleText = GameObject.FindGameObjectWithTag ("TitleText").GetComponent<Text>();
		CreationText = GameObject.FindGameObjectWithTag ("CreatedText").GetComponent<Text>();
		ModifiedText = GameObject.FindGameObjectWithTag ("ModifiedText").GetComponent<Text>();
		DescriptionText = GameObject.FindGameObjectWithTag ("DescriptionText").GetComponent<Text>();
		Hide ();
	}

	void Hide() {
		Canvas.alpha = 0f; 
		Canvas.blocksRaycasts = false; 
	}

	void Show() { 
		Canvas.alpha = 1f; 
		Canvas.blocksRaycasts = true; 
	}

	public void FillDetails(Configuration config) {
		TitleText.text = config.Title;
		CreationText.text = config.CreationDate + " " + config.CreationTime;
		ModifiedText.text = config.ModifiedDate + " " + config.ModifiedTime;
		DescriptionText.text = config.Description;
		Show ();
	}



	
	// Update is called once per frame
	void Update () {
		
	}
}
