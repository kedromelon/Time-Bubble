﻿using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
	public string SceneToLoad;

	void Awake(){
		Application.LoadLevelAdditive(SceneToLoad);

	}

	void Update()
	{
		if (!Application.isLoadingLevel){Destroy(gameObject);} 
	}


}