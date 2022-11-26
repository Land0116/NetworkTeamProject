using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[System.Serializable]
	public class data_Board
	{
		private static data_Board _instance = null;
		public static data_Board Instance
		{
			get
			{
				if (_instance == null)
				{
					return null;
				}
				return _instance;
			}
		}
		public Transform board;

	}

	[Header("DiceNunm")]
	public GameObject diceNumPanel;
    public Text diceNunmtext;
	public int diceNumber;

	[Header("Board")]
	public List<data_Board> map = new List<data_Board>();
	public float speed;

	private static GameManager instance = null;
	public static GameManager Instance
    {
        get
        {
			if(instance == null)
            {
				return null;
            }
			return instance;
        }
    }

	private void Awake()
	{
		if(instance == null)
        {
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
        {
			Destroy(this.gameObject);
        }
	}

	// Use this for initialization
	void Start()
	{
		diceNumPanel.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		
	}

    public void DiceNum()
    {
        diceNunmtext.text = diceNumber.ToString();
    }
}
