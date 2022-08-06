using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;


namespace NumGame
{
    public class BoxSpawn : MonoBehaviour
    {
        [Header("난이도 하")]
        public GameObject box_1;
        public TextMeshProUGUI[] box_1_text;
        public Image[] box_1_img;
        public int[] boxNum_1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [Header("난이도 중")]
        public GameObject box_2;
        public TextMeshProUGUI[] box_2_text;
        public Image[] box_2_img;
        public int[] boxNum_2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        [Header("난이도 상")]
        public GameObject box_3;
        public TextMeshProUGUI[] box_3_text;
        public Image[] box_3_img;
        public int[] boxNum_3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

        private bool isFull = false;
        private void Start()
        {
            GameManager.instance.boxSpawn = this;
        }
        public void BoxSpwn()
        {
            var gm = GameManager.instance;
            int rand;
            int temp;
            if(gm.mod == 1)
            {
                box_1.SetActive(true);
                for (int i = 0; i < boxNum_1.Length; i++)
                {
                    rand = Random.Range(0, 8);
                    temp = boxNum_1[i];
                    boxNum_1[i] = boxNum_1[rand];
                    boxNum_1[rand] = temp;
                }
                for (int i = 0; i < box_1_text.Length; i++)
                {
                    box_1_text[i].SetText(boxNum_1[i].ToString());
                    box_1_text[i].GetComponent<Box>().myNum = boxNum_1[i];
                }
            }
            else if (gm.mod == 2)
            {
                box_2.SetActive(true);
                for (int i = 0; i < boxNum_2.Length; i++)
                {
                    rand = Random.Range(0, 15);
                    temp = boxNum_2[i];
                    boxNum_2[i] = boxNum_2[rand];
                    boxNum_2[rand] = temp;
                }
                for (int i = 0; i < box_2_text.Length; i++)
                {
                    box_2_text[i].SetText(boxNum_2[i].ToString());
                    box_2_text[i].GetComponent<Box>().myNum = boxNum_2[i];
                }
            }
            else if (gm.mod == 3)
            {
                box_3.SetActive(true);
                for (int i = 0; i < boxNum_3.Length; i++)
                {
                    rand = Random.Range(0, 24);
                    temp = boxNum_3[i];
                    boxNum_3[i] = boxNum_3[rand];
                    boxNum_3[rand] = temp;
                }
                for (int i = 0; i < box_3_text.Length; i++)
                {
                    box_3_text[i].SetText(boxNum_3[i].ToString());
                    box_3_text[i].GetComponent<Box>().myNum = boxNum_3[i];
                }
            }

        }


        
    }
}

