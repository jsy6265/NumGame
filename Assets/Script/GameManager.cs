using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NumGame
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;

        public int mod;
        public int score;
        public int next_Num = 1;
        public int global_Heart = 3;
        public bool isStart = false;

        void Awake()
        {
            if (null == instance)
            {
                instance = this;

                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public BoxSpawn boxSpawn;
        public UiManager uiManager;
        public AudioManager audio;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        //���ӽ���, �ڽ� ����, ��Ʈ ������Ʈ Ȱ��ȭ
        public void GameStart()
        {
            boxSpawn.BoxSpwn();
            uiManager.HeartOn();
            isStart = true;
        }

        //Ʋ������ ����� ����
        public void Heart_Des()
        {
            global_Heart--;
            uiManager.heart[global_Heart].SetActive(false);
            if (global_Heart <= 0)
            {
                isStart = false;

                OnEndBord();
            }
            
        }

        //���� ���� Ȥ�� Ŭ���� �� ����UI Ȱ��ȭ
        public void OnEndBord()
        {

            if (mod == 1)
            {
                boxSpawn.box_1.SetActive(false);
            }
            else if (mod == 2)
            {
                boxSpawn.box_2.SetActive(false);
            }
            else if (mod == 3)
            {
                boxSpawn.box_3.SetActive(false);
            }
            uiManager.EndGame();
        }

        public void ResetValue()
        {
            mod = 0;
            score = 0;
            next_Num = 1;
            global_Heart = 3;
            isStart = false;
        }
    }
}

