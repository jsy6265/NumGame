using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


namespace NumGame
{
    public class UiManager : MonoBehaviour
    {
        public GameObject canvas_Pad;
        public GameObject canvas_UI;
        public GameObject Bord;

        [Header("하트")]
        public GameObject global_heart;
        public GameObject[] heart;

        [Header("종료 UI")]
        public GameObject endBord;
        public TextMeshProUGUI endScore;

        void Start()
        {
            GameManager.instance.uiManager = this;
            
        }

        public void SelectMod(int type)
        {
            canvas_UI.SetActive(false);
            Bord.SetActive(true);
            var gm = GameManager.instance;
            if (type == 1)
            {
                gm.mod = 1;
                gm.GameStart();
            }
            else if (type == 2)
            {
                gm.mod = 2;
                gm.GameStart();
            }
            else if (type == 3)
            {
                gm.mod = 3;
                gm.GameStart();
            }
            gm.audio.audio_button.Play();
        }

        public void HeartOn()
        {
            global_heart.SetActive(true);
        }
        
        public void EndGame()
        {
            Bord.SetActive(false);
            global_heart.SetActive(false);
            endBord.SetActive(true);
            endScore.SetText("내 점수 : " + GameManager.instance.score.ToString());
        }

        public void Main()
        {
            GameManager.instance.audio.audio_button.Play();

            GameManager.instance.ResetValue();
            SceneManager.LoadScene(0);
        }

        public void Exit()
        {
            GameManager.instance.audio.audio_button.Play();
            Application.Quit();
        }
    }
}

