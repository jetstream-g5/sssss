using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour {
	
	public int nrOfTotalCollectables;
	public int nrOfCollectedItems;
	// public text collectableText;
	
	void Start()
	{
		GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
		nrOfTotalCollectables = collectables.Length;
		nrOfCollectedItems = 0;
	}
	
	public void AddCollectable()
	{
		nrOfCollectedItems++;
		Debug.Log("Je hebt" + nrOfCollectedItems + " van de" + nrOfTotalCollectables);
		if(nrOfCollectedItems == nrOfTotalCollectables)
		{
			Debug.Log("YOU WIN!!!");
		}
	}
	
	/*void UpdateUI()
    {
        collectableText.text = "Collectables" + nrOfTotalCollectables + "of" + nrOFCollectedItems;
    }*/
}