using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePuzzleScene : MonoBehaviour
{

     public void MovePuzzle()
    {
        SceneManager.LoadScene("Puzzle");
    }
}
