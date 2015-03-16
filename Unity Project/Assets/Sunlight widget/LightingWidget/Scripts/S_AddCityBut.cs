using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S_AddCityBut : MonoBehaviour {
	public RectTransform newCityPanel;
	public RectTransform emptyInputWarningPanel;
	public InputField cityNameInput;
	public InputField longitudeInput;
	public InputField latitudeInput;
	public InputField timeZoneInput;

	public void addCity(){
		if(cityNameInput.text != "" && longitudeInput.text != "" && latitudeInput.text != "" && timeZoneInput.text != ""){
			City city = new City(cityNameInput.text, float.Parse(longitudeInput.text), float.Parse(latitudeInput.text), int.Parse(timeZoneInput.text));
			SunLightWidget.Instance.InputData.CurrentCity = city;
			SunLightWidget.Instance.InputData.ListOfCity.Add(city);
			newCityPanel.gameObject.SetActive(false);
		}else{
			emptyInputWarningPanel.gameObject.SetActive(true);
		}
	}

}
