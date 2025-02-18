using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Resource : MonoBehaviour {
    int turnNum = 1;
    int turnsToWin = 30;
    int popToLose = 100;

    float productionSpeed = 1.3f;
    float scavangeSpeed = 0.8f;

    float workerQuality = 1;
    float soldierQuality = 1;

    float workerMorale = 1.0f;
    float soldierMorale = 1.0f;
    float unemployedMorale = 1.0f;




    int Food;
    int Water;
    int Fuel;
    int Power;
    int Medical;

    int Weapons;

    int FoodChange = 0;
    int WaterChange = 0;
    int FuelChange = 0;
    int PowerChange = 0;
    int MedicalChange = 0;

    int WeaponChange = 0;


    int Population;

    int popUnemployed;
    public int popSoldier;
    int popWorker;
    int popElder;
    int popYouth;

    [SerializeField]
    GameObject dayNumObj;

    [Header("Training UI Info")]
    [SerializeField]
    GameObject soldierNumObj;
    [SerializeField]
    GameObject soldierQualityObj;

    [SerializeField]
    GameObject workerNumObj;
    [SerializeField]
    GameObject workerQualityObj;

    [SerializeField]
    GameObject unemployedNumObj;

    [SerializeField]
    GameObject soldierMoraleObj;
    [SerializeField]
    GameObject workerMoraleObj;
    [SerializeField]
    GameObject unemployedMoraleObj;

    [SerializeField]
    GameObject weaponNumObj;

    [Header("Change Objects")]
    [SerializeField]
    GameObject foodChangeObj;
    [SerializeField]
    GameObject waterChangeObj;
    [SerializeField]
    GameObject fuelChangeObj;
    [SerializeField]
    GameObject medicalChangeObj;
    [SerializeField]
    GameObject powerChangeObj;

    //[SerializeField]
    //GameObject powerChange;

    [Header("Amount Objects")]
    [SerializeField]
    GameObject foodAmountObj;

    [SerializeField]
    GameObject waterAmountObj;

    [SerializeField]
    GameObject fuelAmountObj;

    [SerializeField]
    GameObject medicalAmountObj;

    [SerializeField]
    GameObject powerAmountObj;

    [Header("Population Objects")]

    [SerializeField]
    GameObject totalPopObj;

    [SerializeField]
    GameObject unemployedPopObj;

    [SerializeField]
    GameObject soldierPopObj;

    [SerializeField]
    GameObject workerPopObj;

    [SerializeField]
    GameObject elderYouthPopObj;

    [Header("Pop Percentage Objects")]
    [SerializeField]
    GameObject unemployedPercObj;
    [SerializeField]
    GameObject soldierPercObj;
    [SerializeField]
    GameObject workerPercObj;
    [SerializeField]
    GameObject elderYouthPercObj;

    [Header("Report Objects")]

	[SerializeField] GameObject reportFoodStockObj;
	[SerializeField] GameObject reportFoodWorkerSoldierObj;
	[SerializeField] GameObject reportFoodGiveawayObj;
	[SerializeField] GameObject reportFoodProductionObj;
	[SerializeField] GameObject reportFoodSalvageObj;
	//[SerializeField] GameObject reportFoodExportObj;
    [SerializeField]
    GameObject reportFoodEstimate;
    [SerializeField]
    GameObject reportWaterEstimate;


	[SerializeField] GameObject reportWaterStockObj;
	[SerializeField] GameObject reportWaterWorkerSoldierObj;
	[SerializeField] GameObject reportWaterGiveawayObj;
	[SerializeField] GameObject reportWaterFarmObj;
	[SerializeField] GameObject reportWaterSalvageObj;
	//[SerializeField] GameObject reportWaterExportObj;


    [Header("Resource Assets")]

    [SerializeField]
    GameObject medKit;
    [SerializeField]
    GameObject food1;
    [SerializeField]
    GameObject food2;
    [SerializeField]
    GameObject food3;
    [SerializeField]
    GameObject food4;
    [SerializeField]
    GameObject gas1;
    [SerializeField]
    GameObject gas2;
    [SerializeField]
    GameObject gas3;
    [SerializeField]
    GameObject gun1;
    [SerializeField]
    GameObject gun2;
    [SerializeField]
    GameObject gun3;
    [SerializeField]
    GameObject gun4;
    [SerializeField]
    GameObject gun5;
    [SerializeField]
    GameObject water1;
    [SerializeField]
    GameObject water2;
    [SerializeField]
    GameObject water3;



    // Use this for initialization
    void Start () {
        setInitialResources();
        setResources();
        changeResourceAssets();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
    void setInitialResources()
    {
        popSoldier = Random.Range(50, 60);
        popElder = Random.Range(10, 40);
        popYouth = Random.Range(12, 40);
        popWorker = Random.Range(50, 70);
        popUnemployed = Random.Range(10, 45);

        Food = Random.Range(660, 1500);
        Water = Random.Range(660, 1500);
        Medical = Random.Range(0, 50);
        Fuel = Random.Range(200, 400);
        Weapons = Random.Range(11, 26);
        Power = 0;


        Population = popUnemployed + popSoldier + popWorker + popElder + popYouth;

        unemployedPercObj.GetComponent<Text>().text = ((popUnemployed * 100) / Population).ToString() + "%";
        soldierPercObj.GetComponent<Text>().text = ((popSoldier * 100) / Population).ToString() + "%";
        workerPercObj.GetComponent<Text>().text = ((popWorker * 100) / Population).ToString() + "%";
        elderYouthPercObj.GetComponent<Text>().text = (((popElder + popYouth) * 100) / Population).ToString() + "%";

        dayNumObj.GetComponent<Text>().text = "Day " + turnNum.ToString();
    }
    public int getMedicine()
    {
        return Medical;
    }
    public int getWeapons()
    {
        return Weapons;
    }

    public int getFuel()
    {
        return Fuel;
    }

    public int getWater()
    {
        return Water;
    }

    public int getFood()
    {
        return Food;
    }
    public float getSoldierQuality()
    {
        return soldierQuality;
    }

    public void setResources()
    {
		foodAmountObj.GetComponent<Text>().text = Food.ToString();
        waterAmountObj.GetComponent<Text>().text = Water.ToString();
        fuelAmountObj.GetComponent<Text>().text = Fuel.ToString();
        medicalAmountObj.GetComponent<Text>().text = Medical.ToString();
        powerAmountObj.GetComponent<Text>().text = Power.ToString();

        Population = popUnemployed + popSoldier + popWorker + popElder + popYouth;

        totalPopObj.GetComponent<Text>().text = Population.ToString();
        unemployedPopObj.GetComponent<Text>().text = popUnemployed.ToString();
        soldierPopObj.GetComponent<Text>().text = popSoldier.ToString();
        workerPopObj.GetComponent<Text>().text = popWorker.ToString();
        elderYouthPopObj.GetComponent<Text>().text = (popElder + popYouth).ToString();

        soldierNumObj.GetComponent<Text>().text = popSoldier.ToString();
        workerNumObj.GetComponent<Text>().text = popWorker.ToString();
        unemployedNumObj.GetComponent<Text>().text = popUnemployed.ToString();

        weaponNumObj.GetComponent<Text>().text = "Extra weapons: " + Weapons.ToString();

        soldierQualityObj.GetComponent<Text>().text = ((int)(soldierQuality * 100)).ToString();
        workerQualityObj.GetComponent<Text>().text = ((int)(workerQuality * 100)).ToString();

        soldierMoraleObj.GetComponent<Text>().text = ((int)(soldierMorale * 100)).ToString() + "% happy";
        workerMoraleObj.GetComponent<Text>().text = ((int)(workerMorale * 100)).ToString() + "% happy";
        unemployedMoraleObj.GetComponent<Text>().text = ((int)(unemployedMorale * 100)).ToString() + "% happy";

        unemployedPercObj.GetComponent<Text>().text = ((popUnemployed * 100) / Population).ToString() + "%";
        soldierPercObj.GetComponent<Text>().text = ((popSoldier * 100) / Population).ToString() + "%";
        workerPercObj.GetComponent<Text>().text = ((popWorker * 100) / Population).ToString() + "%";
        elderYouthPercObj.GetComponent<Text>().text = (((popElder + popYouth) * 100) / Population).ToString() + "%";



        int ration = popSoldier + popWorker;
        int giveaway = popUnemployed + popYouth + popElder;
        int produce = ((int)(popWorker * productionSpeed * workerQuality * workerMorale));
        int salvage = ((int)(popUnemployed * scavangeSpeed * unemployedMorale));

        reportFoodStockObj.GetComponent<Text>().text = Food.ToString();
        reportFoodWorkerSoldierObj.GetComponent<Text>().text = "-"+ ration.ToString();
        reportFoodGiveawayObj.GetComponent<Text>().text = "-"+ giveaway.ToString();
        reportFoodProductionObj.GetComponent<Text>().text = "+" + produce.ToString();
        reportFoodSalvageObj.GetComponent<Text>().text = "+"+salvage.ToString();
       //// reportFoodExportObj.GetComponent<Text>().text = "0";

        

        reportWaterStockObj.GetComponent<Text>().text = Water.ToString();
        reportWaterWorkerSoldierObj.GetComponent<Text>().text = "-" + ration.ToString();
        reportWaterGiveawayObj.GetComponent<Text>().text = "-" + giveaway.ToString();
        reportWaterFarmObj.GetComponent<Text>().text = "+" + produce.ToString();
        reportWaterSalvageObj.GetComponent<Text>().text = "+" + salvage.ToString();
        ////  reportWaterExportObj.GetComponent<Text>().text = "0";



        reportFoodEstimate.GetComponent<Text>().text = (Food - giveaway - ration + produce + salvage).ToString();
        reportWaterEstimate.GetComponent<Text>().text = (Water - giveaway - ration + produce + salvage).ToString();
    }
   public void decreasePop(int amount)
    {
        Population -= amount;
        decreasePop();
    }
     
   public void decreasePop()
    {
        while(Population < popUnemployed + popSoldier + popWorker + popElder + popYouth)
        {
            switch(Random.Range(1, 6))
            {
                case 1:
                    if (popUnemployed > 0)
                        popUnemployed--;
                    break;
                case 2:
                    if (popSoldier > 0)
                        popSoldier--;
                    break;
                case 3:
                    if (popWorker > 0)
                        popWorker--;
                    break;
                case 4:
                    if (popElder > 0)
                        popElder--;
                    break;
                case 5:
                    if (popYouth > 0)
                        popYouth--;
                    break;
            }

        }

        if (Population < popToLose)
            LoseGame();


        setResources();
    }
	
    public void WinGame()
    {
        Application.LoadLevel(1);
    }

    public void LoseGame()
    {
        Application.LoadLevel(2);
    }


	public void endTurn(){
        turnNum++;
        dayNumObj.GetComponent<Text>().text = "Day " + turnNum.ToString();

        if (turnNum >= turnsToWin)
            WinGame();

        Population = popUnemployed + popSoldier + popWorker + popElder + popYouth;


        //PRODUCTION
        changeFood((int)(popWorker * productionSpeed * workerQuality *workerMorale));
        changeWater((int)(popWorker * productionSpeed * workerQuality * workerMorale));
        //SCAVANGE
        changeFood((int)(popUnemployed * scavangeSpeed *unemployedMorale));
        changeWater((int)(popUnemployed * scavangeSpeed * unemployedMorale));




        if (Water > Population) {
            //Water -= Population;
            changeWater(-Population);
		} else {
            int difference = Population - Water;
            //Water = 0;
            changeWater(-Water);
            Population -= difference;
            decreasePop();
			// Some people are dehydrated. Add code.
		}

        if (Food >= Population)
        {
            //Food -= Population;
            changeFood(-Population);
        }
        else
        {

            int difference = Population - Food;
            //Food = 0;
            changeFood(-Food);
            Population -= difference;
            decreasePop();

            // Some people starve. Decide what to do?
        }

        foodChangeObj.GetComponent<Text>().text = FoodChange.ToString();
        FoodChange = 0;
        waterChangeObj.GetComponent<Text>().text = WaterChange.ToString();
        WaterChange = 0;
        fuelChangeObj.GetComponent<Text>().text = FuelChange.ToString();
        FuelChange = 0;
        powerChangeObj.GetComponent<Text>().text = PowerChange.ToString();
        PowerChange = 0;
        medicalChangeObj.GetComponent<Text>().text = MedicalChange.ToString();
        MedicalChange = 0;

        WeaponChange = 0;

        setResources ();


        this.gameObject.GetComponent<RandomEvents>().publishEvent();
        this.gameObject.GetComponent<Combat>().changePaperBack();


        if (Population < popToLose)
            LoseGame();

        workerQuality += 0.05f;
        soldierQuality += 0.05f;
        if (workerQuality > 1)
            workerQuality = 1;
        if(soldierQuality>1)
            soldierQuality = 1;

        changeResourceAssets();
	}


    public void changeWeapons(int amount)
    {
        Weapons += amount;
        WeaponChange += amount;
        setResources();
    }
	
	public void changeFood(int amount){
		Food += amount;
        FoodChange += amount;
        setResources();
	}
	
	public void changeWater(int amount){
		Water += amount;
        WaterChange += amount;
        setResources();
	}
	
	public void changeFuel(int amount){
		Fuel += amount;
        FuelChange += amount;
        setResources();
	}

    public void changeMedical(int amount)
    {
        Medical += amount;
        MedicalChange += amount;
        setResources();
    }

    public void changeUnemployed(int amount)
    {
        popUnemployed += amount;
        setResources();
    }
    public void changeSoldier(int amount)
    {
        popSoldier += amount;
        setResources();
    }
    public void changeWorker(int amount)
    {
        popWorker += amount;
        setResources();
    }
    public void changeElder(int amount)
    {
        popElder += amount;
        setResources();
    }
    public void changeYouth(int amount)
    {
        popYouth += amount;
        setResources();
    }
    
    public int getSoldierPop()
    {
        return popSoldier;
    }
    public int getWorkerPop()
    {
        return popWorker;
    }
    public int getUnemployedPop()
    {
        return popUnemployed;
    }
    public int getYouthNElderPop() { return popYouth + popElder; }

    public void trainUnempToSoldier(int amount, bool isHastened)
    {
        changeUnemployed(-amount);
        changeSoldier(amount);
        changeWeapons(-amount);
        if (isHastened || amount > 10)
            soldierQuality -= 0.1f;

        Debug.Log("soldier quality " + soldierQuality);
        setResources();
    }
    public void trainUnempToWorker(int amount, bool isHastened)
    {
        changeUnemployed(-amount);
        changeWorker(amount);
        if (isHastened || amount > 10)
            workerQuality -= 0.1f;
        setResources();
    }
    public void trainWorkerToSoldier(int amount, bool isHastened)
    {
        changeWorker(-amount);
        changeSoldier(amount);
        changeWeapons(-amount);
        if (isHastened || amount > 10)
            soldierQuality -= 0.1f;
        setResources();
    }
    public void trainSoldierToWorker(int amount, bool isHastened)
    {
        changeSoldier(-amount);
        changeWorker(amount);
        changeWeapons(amount);
        if (isHastened || amount > 10)
            workerQuality -= 0.1f;
        setResources();
    }

    public void changeWorkerMorale(float amount)
    {
        workerMorale += amount;
        if (workerMorale > 1)
            workerMorale = 1;

        if (workerMorale <= 0)
            LoseGame();

        setResources();
    }
    public void changeSoldierMorale(float amount)
    {
        soldierMorale += amount;
        if (soldierMorale > 1)
            soldierMorale = 1;
        if (soldierMorale <= 0)
            LoseGame();

        setResources();
    }
    public void changeUnemployedMorale(float amount)
    {
        unemployedMorale += amount;
        if (unemployedMorale > 1)
            unemployedMorale = 1;
        if (unemployedMorale <= 0)
            LoseGame();

        setResources();
    }





    void changeResourceAssets()
    {
        if(Medical > 500)
        {
            medKit.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            medKit.GetComponent<MeshRenderer>().enabled = false;
        }

        if(Fuel < 400)
        {
            gas1.SetActive(false);
            gas2.SetActive(false);
            gas3.SetActive(false);
        }else if(Fuel < 800)
        {
            gas1.SetActive(true);
            gas2.SetActive(false);
            gas3.SetActive(false);
        }
        else if (Fuel < 1200)
        {
            gas1.SetActive(true);
            gas2.SetActive(true);
            gas3.SetActive(false);
        }
        else
        {
            gas1.SetActive(true);
            gas2.SetActive(true);
            gas3.SetActive(true);
        }

        if(Food < 500)
        {
            food1.GetComponent<MeshRenderer>().enabled = false;
            food2.GetComponent<MeshRenderer>().enabled = false;
            food3.GetComponent<MeshRenderer>().enabled = false;
            food4.GetComponent<MeshRenderer>().enabled = false;
        }else if(Food < 1000)
        {
            food1.GetComponent<MeshRenderer>().enabled = true;
            food2.GetComponent<MeshRenderer>().enabled = false;
            food3.GetComponent<MeshRenderer>().enabled = false;
            food4.GetComponent<MeshRenderer>().enabled = false;
        }else if(Food < 1500)
        {
            food1.GetComponent<MeshRenderer>().enabled = true;
            food2.GetComponent<MeshRenderer>().enabled = true;
            food3.GetComponent<MeshRenderer>().enabled = false;
            food4.GetComponent<MeshRenderer>().enabled = false;
        }
        else if(Food < 2000)
        {
            food1.GetComponent<MeshRenderer>().enabled = true;
            food2.GetComponent<MeshRenderer>().enabled = true;
            food3.GetComponent<MeshRenderer>().enabled = true;
            food4.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            food1.GetComponent<MeshRenderer>().enabled = true;
            food2.GetComponent<MeshRenderer>().enabled = true;
            food3.GetComponent<MeshRenderer>().enabled = true;
            food4.GetComponent<MeshRenderer>().enabled = true;
        }

        
        if(Water < 500)
        {
            water1.SetActive(false);
            water2.SetActive(false);
            water3.SetActive(false);
        }
        else if(Water < 1000)
        {
            water1.SetActive(true);
            water2.SetActive(false);
            water3.SetActive(false);
        }
        else if(Water < 1500)
        {
            water1.SetActive(true);
            water2.SetActive(true);
            water3.SetActive(false);
        }
        else
        {
            water1.SetActive(true);
            water2.SetActive(true);
            water3.SetActive(true);
        }


        if(Weapons < 5)
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
            gun3.SetActive(false);
            gun4.SetActive(false);
            gun5.SetActive(false);    
        }else if (Weapons < 10)
        {
            gun1.SetActive(true);
            gun2.SetActive(false);
            gun3.SetActive(false);
            gun4.SetActive(false);
            gun5.SetActive(false);
        }
        else if (Weapons < 15)
        {
            gun1.SetActive(true);
            gun2.SetActive(true);
            gun3.SetActive(false);
            gun4.SetActive(false);
            gun5.SetActive(false);
        }
        else if (Weapons < 20)
        {
            gun1.SetActive(true);
            gun2.SetActive(true);
            gun3.SetActive(true);
            gun4.SetActive(false);
            gun5.SetActive(false);
        }
        else if (Weapons < 25)
        {
            gun1.SetActive(true);
            gun2.SetActive(true);
            gun3.SetActive(true);
            gun4.SetActive(true);
            gun5.SetActive(false);
        }
        else
        {
            gun1.SetActive(true);
            gun2.SetActive(true);
            gun3.SetActive(true);
            gun4.SetActive(true);
            gun5.SetActive(true);
        }


    }


}
