using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using DataCharacter;


public class GameManager : MonoBehaviour
{

    #region Private_Variable
    //string and numeric
    [Header("String and numeric")]
    [SerializeField]//menampilkan variable string pada inspector
    private string detectedTrackerName;
    [SerializeField]
    private GameObject[] characterPrefabs;
    [SerializeField]
    private CharacterDatas[] charDatas;
    #endregion

    #region Public_Variable

    [Header("UI Sector")]
    public Text descriptionText;
    public Text characterNameText;
    public GameObject UIDescription;

    #endregion

    void Awake()
    {
        charDatas = Resources.LoadAll("CharacterData",typeof(CharacterDatas)).Cast<CharacterDatas>().ToArray();
    }

    void Update()
    {

        Detection();

    }

    private void Detection()
    {

        detectedTrackerName = PlayerPrefs.GetString("TrackerName");
        Debug.Log("Tracker Name : " + detectedTrackerName);

        for (int i = 0; i < characterPrefabs.Length; i++)
        {

            for (int j = 0; j < charDatas.Length; j++)
            {

                if (characterPrefabs[i].name.Contains(charDatas[j].characterName) && detectedTrackerName.Contains(charDatas[j].characterName))
                {

                    characterPrefabs[i].SetActive(true);
                    characterNameText.text = charDatas[j].characterName.ToString();
                    descriptionText.text = charDatas[j].characterDes.ToString();
                    UIDescription.SetActive(true);

                }
                else if(detectedTrackerName == "")
                {

                    characterPrefabs[i].SetActive(false);
                    characterNameText.text = "";
                    descriptionText.text = "";
                    UIDescription.SetActive(false);

                }

            }

        }

    }

    #region Duty
    /*public void TrackerDetector(string nameTracker)
    {
        
        Debug.Log("Tracker Name : " + nameTracker);
        detectedTrackerName = nameTracker;

    }*/

    #endregion

}
