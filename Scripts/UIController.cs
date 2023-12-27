using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Action OnRoadPlacement,OnHospitalPlacement, OnBigPlacement, OnWaterSupplyPlacement,OnSolarPlacement, OnHousePlacement, OnGasPlacement, OnShopPlacement, OnSpecialPlacement, OnSchoolPlacement, OnToiletPlacement, OnGPPlacement, OnSewagePlacement, OnWaterSprinklerPlacement, OnWindmillPlacement, OnCSCPlacement, OnAnganwadiPlacement, OnPostOfficePlacement;
    public Button placeRoadButton, placeBigStructure, placeHospitalButton, placeWaterSupplyButton, placeSolarButton, placeHouseButton, placeGasButton, placeShopButton, placeSpecialButton, placeSchoolButton, placeToiletButton, placeGPButton, placeSewageButton, placeWaterSprinklerButton, placeWindmillButton, placeCSCButton, placeAnganWadiButton, placePostOfficeButton;

    public Color outlineColor;
    List<Button> buttonList;

    private void Start()
    {
        buttonList = new List<Button> { placeHouseButton,placeBigStructure, placeHospitalButton, placeSolarButton, placeWaterSupplyButton, placeGasButton, placeSchoolButton, placeShopButton, placeRoadButton, placeSpecialButton, placeGPButton, placeAnganWadiButton, placeSewageButton, placeToiletButton, placeWaterSprinklerButton, placeWindmillButton, placeCSCButton, placePostOfficeButton };

        placeRoadButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeRoadButton);
            OnRoadPlacement?.Invoke();

        });
        placeHouseButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHouseButton);
            OnHousePlacement?.Invoke();

        });
        placeSpecialButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSpecialButton);
            OnSpecialPlacement?.Invoke();

        });
        placeSewageButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSewageButton);
            OnSewagePlacement?.Invoke();

        });
        placeToiletButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeToiletButton);
            OnToiletPlacement?.Invoke();

        });
        placeWaterSprinklerButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeWaterSprinklerButton);
            OnWaterSprinklerPlacement?.Invoke();

        });
        placeWindmillButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeWindmillButton);
            OnWindmillPlacement?.Invoke();

        });
        placeCSCButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeCSCButton);
            OnCSCPlacement?.Invoke();

        });
        placePostOfficeButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placePostOfficeButton);
            OnPostOfficePlacement?.Invoke();

        });
        placeAnganWadiButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeAnganWadiButton);
            OnAnganwadiPlacement?.Invoke();

        });
        placeGPButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeGPButton);
            OnGPPlacement?.Invoke();

        });
        placeGasButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeGasButton);
            OnGasPlacement?.Invoke();

        });
        placeShopButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeShopButton);
            OnShopPlacement?.Invoke();

        });
        
        placeSchoolButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSchoolButton);
            OnSchoolPlacement?.Invoke();

        });
        
        placeHospitalButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHospitalButton);
            OnHospitalPlacement?.Invoke();

        });
        placeSolarButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSolarButton);
            OnSolarPlacement?.Invoke();

        });
        placeWaterSupplyButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeWaterSupplyButton);
            OnWaterSupplyPlacement?.Invoke();

        });

    }

    private void ModifyOutline(Button button)
    {
        var outline = button.GetComponent<Outline>();
        outline.effectColor = outlineColor;
        outline.enabled = true;
    }

    private void ResetButtonColor()
    {
        foreach (Button button in buttonList)
        {
            button.GetComponent<Outline>().enabled = false;
        }
    }
}