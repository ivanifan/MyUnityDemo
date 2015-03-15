using UnityEngine;
using System.Collections;

public class AutoAddLightingWidget : MonoBehaviour {
	public GameObject lightingWidget; // hold the Panel Gameobject
	public UIInput inputfield;
	public UISlider slider;
	public UIPopupList list;
	public UIButtonMessage startButton;
	public UICheckbox checkbox;
	
	// Use this for initialization
	void Start () {
		lightingWidget = transform.root.Find("LightingWidget").gameObject;
		if (gameObject.GetComponent<UIInput>() != null){
			inputfield = gameObject.GetComponent<UIInput>();
			inputfield.eventReceiver = lightingWidget.gameObject;
		}
		if (gameObject.GetComponent<UISlider>() != null){
			slider = gameObject.GetComponent<UISlider>();
			slider.eventReceiver = lightingWidget.gameObject;
		}
		if (gameObject.GetComponent<UIPopupList>() != null){
			list = gameObject.GetComponent<UIPopupList>();
			list.eventReceiver = lightingWidget.gameObject;
		}
		if (gameObject.GetComponent<UIButtonMessage>() != null){
			startButton = gameObject.GetComponent<UIButtonMessage>();
			startButton.target = lightingWidget.gameObject;
		}
		if (gameObject.GetComponent<UICheckbox>() != null){
			checkbox = gameObject.GetComponent<UICheckbox>();
			checkbox.eventReceiver = lightingWidget.gameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
