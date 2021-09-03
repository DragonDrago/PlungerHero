using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greedy : MonoBehaviour {

	List<string> states_needed = new List<string> { "mt", "wa","or","id", "nv", "ut","ca", "az" };
	List<string> final_stations = new List<string>();

	Dictionary<string, List<string>> stations = new Dictionary<string, List<string>>()
	{

		{"kOne", new List<string>(){"id","nv","ut"}},
		{"kTwo", new List<string>(){"wa","id","mt"}},
		{"kThree", new List<string>(){"or","nv","ca"}},
		{"kFour", new List<string>(){"nv","ut" }},
		{"kFive", new List<string>(){ "ca","az"}}
	};


	void Start () {

      while(states_needed.Count > 0)
        {
			string best_station = "";
			List<string> states_covered = new List<string>();
		}
		
	}
	
	
}
