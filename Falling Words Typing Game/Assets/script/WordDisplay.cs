using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public Text score;
	
	public static float fallSpeed = 1f;
	

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
		
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
		if (text.transform.position.y <= -5f) // if word falls below screen, destroy it 
		{
			Destroy(gameObject);
			SceneManager.LoadScene(2);
		}
		
		
	}

}
