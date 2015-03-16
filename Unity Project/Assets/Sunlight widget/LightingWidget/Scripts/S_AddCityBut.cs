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
	public Text cityOnDisplay;
	public RectTransform contentPanel;

	public void addCity(){
		if(cityNameInput.text != "" && longitudeInput.text != "" && latitudeInput.text != "" && timeZoneInput.text != ""){
			City city = new City(cityNameInput.text, float.Parse(longitudeInput.text), float.Parse(latitudeInput.text), int.Parse(timeZoneInput.text));
			if(cityExisted(city.CityName)){
				//overwrite, continue?
			}else{
				SunLightWidget.Instance.InputData.CurrentCity = city;
				SunLightWidget.Instance.InputData.ListOfCity.Add(city); //add new city to database
				SunLightWidget.Instance.saveDataToXML();// save to xml
				cityOnDisplay.text = city.CityName; //change the display city
				SunLightWidget.Instance.AddNewCityToDropDown(city.CityName);
				newCityPanel.gameObject.SetActive(false);
				if(! SunLightWidget.Instance.CityDropdownLongEnough()){
					SunLightWidget.Instance.IncreaseCityDropdownSize();
				}
			}
			SunLightWidget.Instance.calcSunCoordination();
		}else{
			emptyInputWarningPanel.gameObject.SetActive(true);
		}
	}



	//return the city if found duplicate, return null if not found
	bool cityExisted(string cityName){
		foreach(City city in SunLightWidget.Instance.InputData.ListOfCity){
			if(city.CityName == cityName){
				return true;
			}
		}
		return false;
	}
}
