using SVS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StructureManager : MonoBehaviour
{
    public StructurePrefabWeighted[] housesPrefabe, solarPrefabe, hospitalPrefabe, watersupplyPrefabe ,specialPrefabs, bigStructuresPrefabs, gasPrefabe, shopPrefabe, schoolPrefabe, toiletPrefabe, gpPrefabe, sewagePrefabe, waterSprinklePrefabe, windmillPrefabe, cscPrefabe, anganwadiPrefabe, postofficePrefabe;
    public PlacementManager placementManager;

    public Wallet wallet;
    public Text amount;
    int cost_road;
    int cost_hospital;
    int cost_watersupply;
    int cost_solar;
    int cost_structure;
    int  cost_special ;
       int cost_bigStructure;
        int cost_gas;
    int cost_shop;
    int cost_school;
    int cost_toilet;
    int cost_gp;
    int cost_sewage;
    int cost_postoffice;
    int cost_anganwadi;
    int cost_CSC;
    int cost_windmill;
    int cost_WaterSprinkler;



    private float[] houseWeights, hospitalWeights, solarWeights, watersupplyWeights, specialWeights, bigStructureWeights, gasWeights, shopWeights, schoolWeights, toiletWeights, gpWeights, sewageWeights,waterSprinkleWeights, windmillWeights, cscWeights, anganwadiWeights, postofficeWeights;

    private void Start()
    {
        cost_structure = 100000;
        cost_road = 25000;
        cost_special = 100000;
        cost_bigStructure = 4000000;
         cost_gas = 500000;
         cost_shop = 200000;
         cost_school = 300000;
         cost_toilet = 100000;
         cost_gp = 100000;
         cost_sewage = 300000;
         cost_postoffice = 300000;
         cost_anganwadi = 500000;
         cost_CSC = 400000;
         cost_windmill = 100000;
         cost_WaterSprinkler = 50000;
        cost_solar = 500000;
        cost_hospital = 2000000;
        cost_watersupply = 1000000;

        houseWeights = housesPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        specialWeights = specialPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        bigStructureWeights = bigStructuresPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        gasWeights = gasPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        shopWeights = shopPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        schoolWeights = schoolPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        toiletWeights = toiletPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        gpWeights = gpPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        sewageWeights = sewagePrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        waterSprinkleWeights = waterSprinklePrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        windmillWeights = windmillPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        cscWeights = cscPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        anganwadiWeights = anganwadiPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        postofficeWeights = postofficePrefabe.Select(prefabStats => prefabStats.weight).ToArray();
    }

    public void PlaceHouse(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_structure)
            {
                wallet.current_amount -= cost_structure;
                int randomIndex = GetRandomWeightedIndex(houseWeights);
                placementManager.PlaceObjectOnTheMap(position, housesPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceGas(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_gas)
            {
                wallet.current_amount -= cost_gas;
                int randomIndex = GetRandomWeightedIndex(gasWeights);
                placementManager.PlaceObjectOnTheMap(position,gasPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceShop(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_shop)
            {
                wallet.current_amount -= cost_shop;
                int randomIndex = GetRandomWeightedIndex(shopWeights);
                placementManager.PlaceObjectOnTheMap(position, shopPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceSchool(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_school)
            {
                wallet.current_amount -= cost_school;
                int randomIndex = GetRandomWeightedIndex(schoolWeights);
                placementManager.PlaceObjectOnTheMap(position, schoolPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceToilet(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_toilet)
            {
                wallet.current_amount -= cost_toilet;
                int randomIndex = GetRandomWeightedIndex(toiletWeights);
                placementManager.PlaceObjectOnTheMap(position, toiletPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceGP(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_gp)
            {
                wallet.current_amount -= cost_gp;
                int randomIndex = GetRandomWeightedIndex(gpWeights);
                placementManager.PlaceObjectOnTheMap(position, gpPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceSewage(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_sewage)
            {
                wallet.current_amount -= cost_sewage;
                int randomIndex = GetRandomWeightedIndex(sewageWeights);
                placementManager.PlaceObjectOnTheMap(position, sewagePrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceWaterSprinkler(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_WaterSprinkler)
            {
                wallet.current_amount -= cost_WaterSprinkler;
                int randomIndex = GetRandomWeightedIndex(waterSprinkleWeights);
                placementManager.PlaceObjectOnTheMap(position, waterSprinklePrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceWindMill(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_windmill)
            {
                wallet.current_amount -= cost_windmill;
                int randomIndex = GetRandomWeightedIndex(windmillWeights);
                placementManager.PlaceObjectOnTheMap(position, windmillPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceCSC(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_CSC)
            {
                wallet.current_amount -= cost_CSC;
                int randomIndex = GetRandomWeightedIndex(cscWeights);
                placementManager.PlaceObjectOnTheMap(position, cscPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlaceAnganwadi(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_anganwadi)
            {
                wallet.current_amount -= cost_anganwadi;
                int randomIndex = GetRandomWeightedIndex(anganwadiWeights);
                placementManager.PlaceObjectOnTheMap(position, anganwadiPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    public void PlacePostOffice(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_postoffice)
            {
                wallet.current_amount -= cost_postoffice;
                int randomIndex = GetRandomWeightedIndex(postofficeWeights);
                placementManager.PlaceObjectOnTheMap(position, postofficePrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    internal void PlaceBigStructure(Vector3Int position)
    {
        int width = 2;
        int height = 2;
        if (CheckBigStructure(position, width, height))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_hospital)
            {
                wallet.current_amount -= cost_hospital;
                int randomIndex = GetRandomWeightedIndex(hospitalWeights);
                placementManager.PlaceObjectOnTheMap(position, hospitalPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
    }
    internal void PlaceHospital(Vector3Int position)
    {
        int width = 2;
        int height = 2;
        if (CheckBigStructure(position, width, height))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_hospital)
            {
                wallet.current_amount -= cost_hospital;
                int randomIndex = GetRandomWeightedIndex(hospitalWeights);
                placementManager.PlaceObjectOnTheMap(position, hospitalPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
    }
    internal void PlaceSolar(Vector3Int position)
    {
        int width = 2;
        int height = 2;
        if (CheckBigStructure(position, width, height))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_solar)
            {
                wallet.current_amount -= cost_solar;
                int randomIndex = GetRandomWeightedIndex(solarWeights);
                placementManager.PlaceObjectOnTheMap(position, solarPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
    }
    internal void PlaceWaterSupply(Vector3Int position)
    {
        int width = 2;
        int height = 2;
        if (CheckBigStructure(position, width, height))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_watersupply)
            {
                wallet.current_amount -= cost_watersupply;
                int randomIndex = GetRandomWeightedIndex(watersupplyWeights);
                placementManager.PlaceObjectOnTheMap(position, watersupplyPrefabe[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
    }

    private bool CheckBigStructure(Vector3Int position, int width, int height)
    {
        bool nearRoad = false;
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                var newPosition = position + new Vector3Int(x, 0, z);

                if (DefaultCheck(newPosition) == false)
                {
                    return false;
                }
                if (nearRoad == false)
                {
                    nearRoad = RoadCheck(newPosition);
                }
            }
        }
        return nearRoad;
    }

    public void PlaceSpecial(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            int balance = wallet.current_amount;
            if (balance >= cost_special)
            {
                wallet.current_amount -= cost_special;
                int randomIndex = GetRandomWeightedIndex(specialWeights);
                placementManager.PlaceObjectOnTheMap(position, specialPrefabs[randomIndex].prefab, CellType.Structure);
                AudioPlayer.instance.PlayPlacementSound();
                amount.text = wallet.current_amount.ToString();
            }
            else
            {
                Debug.Log("not enough balance");
            }
        }
        else
        {

        }
    }
    private int GetRandomWeightedIndex(float[] weights)
    {
        float sum = 0f;
        for (int i = 0; i < weights.Length; i++)
        {
            sum += weights[i];
        }

        float randomValue = UnityEngine.Random.Range(0, sum);
        float tempSum = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            //0->weihg[0] weight[0]->weight[1]
            if (randomValue >= tempSum && randomValue < tempSum + weights[i])
            {
                return i;
            }
            tempSum += weights[i];
        }
        return 0;
    }

    private bool CheckPositionBeforePlacement(Vector3Int position)
    {
        if (DefaultCheck(position) == false)
        {
            return false;
        }

        if (RoadCheck(position) == false)
            return false;

        return true;
    }

    private bool RoadCheck(Vector3Int position)
    {
        if (placementManager.GetNeighboursOfTypeFor(position, CellType.Road).Count <= 0)
        {
            Debug.Log("Must be placed near a road");
            return false;
        }
        return true;
    }

    private bool DefaultCheck(Vector3Int position)
    {
        if (placementManager.CheckIfPositionInBound(position) == false)
        {
            Debug.Log("This position is out of bounds");
            return false;
        }
        if (placementManager.CheckIfPositionIsFree(position) == false)
        {
            Debug.Log("This position is not EMPTY");
            return false;
        }
        return true;
    }
}

[Serializable]
public struct StructurePrefabWeighted
{
    public GameObject prefab;
    [Range(0, 1)]
    public float weight;
}