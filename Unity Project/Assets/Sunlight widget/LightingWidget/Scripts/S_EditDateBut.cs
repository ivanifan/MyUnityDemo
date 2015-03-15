using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S_EditDateBut : MonoBehaviour {
	public RectTransform labelPanel;
	public RectTransform inputPanel;

	private RectTransform monthInput;
	private RectTransform dateInput;
	private RectTransform yearInput;

	private Text monthLabel;
	private Text dateLabel;
	private Text yearLabel;

	bool isEditMode = false;

	public void editDateClicked(){
		if(isEditMode){
			isEditMode = false;
			this.GetComponent<Image>().color = new Color(1,1,1);
			labelPanel.gameObject.SetActive(true);
			inputPanel.gameObject.SetActive(false);

			establishRefToDateUIs();
			monthLabel.text = monthInput.GetComponent<InputField>().text;
			dateLabel.text = dateInput.GetComponent<InputField>().text;
			yearLabel.text = yearInput.GetComponent<InputField>().text;

			//save the changes to xml
			SunLightWidget.Instance.InputData.updateDateMonYear(int.Parse(dateLabel.text), int.Parse(monthLabel.text), int.Parse(yearLabel.text));
			SunLightWidget.Instance.saveDataToXML();
			
		}else{//now in editmode
			isEditMode = true;
			this.GetComponent<Image>().color = new Color(0.67f, 0.67f, 0.67f);
			labelPanel.gameObject.SetActive(false);
			inputPanel.gameObject.SetActive(true);

			establishRefToDateUIs();
			monthInput.GetComponent<InputField>().text = monthLabel.text;
			dateInput.GetComponent<InputField>().text = dateLabel.text;
			yearInput.GetComponent<InputField>().text = yearLabel.text;

		}
	}

	//find the reference to the date input fields and date labels
	void establishRefToDateUIs(){
		if(monthInput == null || dateInput == null || yearInput == null){
			monthInput = inputPanel.FindChild("MonthInput") as RectTransform;
			dateInput = inputPanel.FindChild("DateInput") as RectTransform;
			yearInput = inputPanel.FindChild("YearInput") as RectTransform;
		}

		if(monthLabel == null || dateLabel == null || yearLabel == null){
			monthLabel = labelPanel.FindChild("Month").GetComponent<Text>();
			dateLabel = labelPanel.FindChild("Date").GetComponent<Text>();
			yearLabel = labelPanel.FindChild("Year").GetComponent<Text>();
		}

		return;
	}
}
