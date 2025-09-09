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

    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32; 
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel); 
        Debug.Log(nextSkillLevel); 
        Debug.Log(GenerateCharacter("Faye", characterLevel));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Time for action - adding comments     
    /// Computes a modified age integer      
    ///</summary>   
    
    void ComputeAge()     
    {         
        Debug.Log(CurrentAge + AddedAge);     
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level += 5;
    }
}
