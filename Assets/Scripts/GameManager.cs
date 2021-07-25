using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour  {

  private string[,] Board = new string[8, 8]{
    {"rook", "knight", "bishop", "king", "queen", "bishop", "knight", "rook"},
    {"pawn", "pawn", "pawn", "pawn", "pawn", "pawn", "pawn", "pawn"},
    {null, null, null, null, null, null, null, null},
    {null, null, null, null, null, null, null, null},
    {null, null, null, null, null, null, null, null},
    {null, null, null, null, null, null, null, null},
    {"pawn", "pawn", "pawn", "pawn", "pawn", "pawn", "pawn", "pawn"},
    {"rook", "knight", "bishop", "king", "queen", "bishop", "knight", "rook"}
  };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
