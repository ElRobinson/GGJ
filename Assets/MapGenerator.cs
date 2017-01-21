using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Assets
{
    class MapGenerator : MonoBehaviour
    {
        public int width;
        public int height;

        private IEnumerator coroutine;

        //necessary for path calc ?
        public int time = 0;

        int[,] map;

        public GameObject [] pecas;

        void Start()
        {
            GenerateMap();
        }

        void GenerateMap()
        {
            coroutine = GenerateObjects(2.0f);
            StartCoroutine(coroutine);            
               
        }

        private IEnumerator GenerateObjects(float spawTime)
        {

            while (true)
            {
                System.Random rnd = new System.Random();

                //for (int i = 0; i < 10; i++)
                //{
                    GameObject obj;
                    obj = GameObject.Instantiate(pecas[rnd.Next(0, 2)], this.transform.position, new Quaternion());
                    Debug.Log(obj.name);
                //}

                yield return new WaitForSeconds(spawTime);

            }
            


        }

        }

    }
    

    



