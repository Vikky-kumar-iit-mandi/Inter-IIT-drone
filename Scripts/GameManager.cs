using SVS;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CameraMovement cameraMovement;
    public RoadManager roadManager;
    public InputManager inputManager;

    public UIController uiController;


    public StructureManager structureManager;
    

    private void Start()
    {
        uiController.OnRoadPlacement += RoadPlacementHandler;
        uiController.OnHousePlacement += HousePlacementHandler;
        uiController.OnGasPlacement += GasPlacementHandler;
        uiController.OnBigPlacement += CollegePlacementHandler;
        uiController.OnPostOfficePlacement += PostOfficePlacementHandler;
        uiController.OnAnganwadiPlacement += AnganwadiPlacementHandler;
        uiController.OnCSCPlacement += CSCPlacementHandler;
        uiController.OnWindmillPlacement += WindmillPlacementHandler;
        uiController.OnWaterSprinklerPlacement += WaterSprinklerPlacementHandler;
        uiController.OnSewagePlacement += SewagePlacementHandler;
        uiController.OnGPPlacement += GPPlacementHandler;
        uiController.OnToiletPlacement += ToiletPlacementHandler;
        uiController.OnSchoolPlacement += SchoolPlacementHandler;
        uiController.OnSpecialPlacement += SpecialPlacementHandler;
        uiController.OnShopPlacement += ShopPlacementHandler;
        uiController.OnHospitalPlacement += HospitalPlacementHandler;
        uiController.OnSolarPlacement += SolarPlacementHandler;
        uiController.OnWaterSupplyPlacement += WaterSupplyPlacementHandler;

    }
    private void HospitalPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceCSC;
    }
    private void SolarPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceCSC;
    }
    private void WaterSupplyPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceCSC;
    }

    private void CollegePlacementHandler()
    {
        ClearInputActions();

        inputManager.OnMouseClick += structureManager.PlaceBigStructure;
    }

    private void GasPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceGas;
    }
    private void ShopPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceShop;
    }
    private void SpecialPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceSpecial;
    }
    private void SchoolPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceSchool;
    }
    private void ToiletPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceToilet;
    }
    private void GPPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceGP;
    }
    private void SewagePlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceSewage;
    }
    private void WaterSprinklerPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceWaterSprinkler;
    }
    private void WindmillPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceWindMill;
    }
    private void CSCPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceCSC;
    }
    private void AnganwadiPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceAnganwadi;
    }
    private void PostOfficePlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlacePostOffice;
    }
    private void HousePlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceHouse;
        
    }

    private void RoadPlacementHandler()
    {
        ClearInputActions();

        inputManager.OnMouseClick += roadManager.PlaceRoad;
        inputManager.OnMouseHold += roadManager.PlaceRoad;
        inputManager.OnMouseUp += roadManager.FinishPlacingRoad;
    }

    private void ClearInputActions()
    {
        inputManager.OnMouseClick = null;
        inputManager.OnMouseHold = null;
        inputManager.OnMouseUp = null;
    }

    private void Update()
    {
        cameraMovement.MoveCamera(new Vector3(inputManager.CameraMovementVector.x, 0, inputManager.CameraMovementVector.y));
    }
}