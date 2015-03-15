using UnityEngine;
using System.Collections.Generic;

public class S_CitySelected : MonoBehaviour {
	string cityName = "";

	//called by the On Click() on each item of the city dropdown list
	public void clicked(){
		cityName = this.transform.FindChild("Text").GetComponent<UnityEngine.UI.Text>().text;
		SunLightWidget.Instance.InputData.setCurrentCityByName(cityName);
		transform.parent.parent.parent.FindChild("Text").GetComponent<UnityEngine.UI.Text>().text = cityName;
		transform.parent.parent.gameObject.SetActive(false);
	}
	
}
