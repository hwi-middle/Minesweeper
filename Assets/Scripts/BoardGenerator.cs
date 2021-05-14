using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ESectorInfo
{
    Empty,
    Mine,
    Flagged
};

public class BoardGenerator
{
    int[,] board;
    int width;
    int height;
    int mineNum;

    public BoardGenerator(int width, int height, int mineNum)
    {
        board = new int[width, height];
        this.width = width;
        this.height = height;
        this.mineNum = mineNum;
    }

    public ESectorInfo GetSectorInfoByCoordinate(int x, int y) 
    {
        return ESectorInfo.Empty; //юс╫ц
    }

}
