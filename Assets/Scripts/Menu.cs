using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scenes.Scripts
{
    public class Menu : MonoBehaviour
    {
        public override bool Equals(object other) => base.Equals(other);
        public override int GetHashCode() => base.GetHashCode();

        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public override string ToString() => base.ToString();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}