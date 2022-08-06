using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace NumGame
{
    public class Box : MonoBehaviour
    {
        public int myNum;

        public void Cheak_Box()
        {
            if(myNum == GameManager.instance.next_Num && GameManager.instance.isStart == true)
            {
                GameManager.instance.audio.audio_box.Play();
                gameObject.SetActive(false);
                GameManager.instance.next_Num++;
                GameManager.instance.score += 10;
            }
            else if(myNum != GameManager.instance.next_Num && GameManager.instance.isStart == true)
            {
                GameManager.instance.Heart_Des();
            }

            if (GameManager.instance.mod == 1 && GameManager.instance.score >= 90)
            {
                GameManager.instance.isStart = false;

                GameManager.instance.OnEndBord();
            }
            else if (GameManager.instance.mod == 2 && GameManager.instance.score >= 160)
            {
                GameManager.instance.isStart = false;

                GameManager.instance.OnEndBord();
            }
            else if (GameManager.instance.mod == 3 && GameManager.instance.score >= 250)
            {
                GameManager.instance.isStart = false;

                GameManager.instance.OnEndBord();
            }

        }
    }
}

