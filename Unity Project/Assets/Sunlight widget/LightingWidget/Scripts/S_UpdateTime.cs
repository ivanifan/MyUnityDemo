using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S_UpdateTime : MonoBehaviour {
	public Slider sliderbar;

	public void updateTime(){
		int hours = 0;
		int min = 0;

		hours = (int)(sliderbar.value * 24.0f);
		min = (int)((sliderbar.value * 24.0f - hours) * 60);
		this.GetComponent<Text>().text = hours.ToString() + " : " + min.ToString();
	}
}
