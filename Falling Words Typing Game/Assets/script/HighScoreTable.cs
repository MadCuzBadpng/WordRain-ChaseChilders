using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;


    private void Awake()
    {
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        highscoreEntryList = new List<HighscoreEntry>()
        {
            new HighscoreEntry{ score = 578643, name = "AAA" },
            new HighscoreEntry{ score = 421523, name = "JOE" },
            new HighscoreEntry{ score = 78643, name = "CAT" },
            new HighscoreEntry{ score = 57623, name = "JON" },
            new HighscoreEntry{ score = 5786, name = "BAD" },
            new HighscoreEntry{ score = 643, name = "DDD" },
            new HighscoreEntry{ score = 43, name = "EEE" },
            new HighscoreEntry{ score = 48631, name = "ABA" },
        };

        foreach (HighscoreEntry highscoreEntry in highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }
    }

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform Container, List<Transform> transformList)
    {
        float templateHeight = 35f;
        Transform entryTransform = Instantiate(entryTemplate, Container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;

            case 1: rankString = "1st"; break;
            case 2: rankString = "2nd"; break;
            case 3: rankString = "3rd"; break;
        }


        entryTransform.Find("posText").GetComponent<Text>().text = rankString;
        
        int score = highscoreEntry.score;

        entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

        string name = highscoreEntry.name;
        entryTransform.Find("nameText").GetComponent<Text>().text = name;
        transformList.Add(entryTransform);
    }
    

    private class HighscoreEntry
    {
        public int score;
        public string name;
    }
}
