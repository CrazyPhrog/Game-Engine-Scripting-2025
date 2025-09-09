using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30; 
    public int AddedAge = 1; 
    public float Pi = 3.14f; 
    public string FirstName = "Harrison"; 
    public bool IsAuthor = true;
    public bool HasDungeonKey = true;
    public int CurrentGold = 32;
    public bool WeaponEquipped = true; 
    public string WeaponType = "Longsword";
    public bool PureOfHeart = true; 
    public bool HasSecretIncantation = false; 
    public string RareItem = "Relic Stone";

    // Start is called before the first frame update
    void Start()
    {
        Thievery();
        ComputeAge();
        OpenTreasureChamber();
        int characterLevel = 32; 
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel); 
        Debug.Log(nextSkillLevel); 
        Debug.Log(GenerateCharacter("Faye", characterLevel));
        if (HasDungeonKey) { Debug.Log("You possess the sacred key: enter."); 
        } 
        else 
        { 
         Debug.Log("You have not proved yourself yet."); 
        }
        if (WeaponEquipped) 
        { 
          if (WeaponType == "Longsword") 
          { 
            Debug.Log("For the Queen!"); 
          } 
        } 
        else 
        { 
          Debug.Log("Fists aren't going to work against armor..."); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Time for action - adding comments     
    /// Computes a modified age integer      
    ///</summary>   
    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }
    void ComputeAge()     
    {         
        Debug.Log(CurrentAge + AddedAge);     
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level += 5;
    }

    public void Thievery() 
    { if (CurrentGold > 50) 
      { 
       Debug.Log("You're rolling in it!"); 
      } 
      else if (CurrentGold < 15) 
      { 
        Debug.Log("Not much there to steal...");
      } 
      else 
      { 
       Debug.Log("Looks like your purse is in the sweet spot.");
      }
    }
}
