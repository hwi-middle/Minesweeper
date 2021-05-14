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
    private int[,] mBoard;
    private int mWidth;
    private int mHeight;
    private int mMineNum;

    public BoardGenerator(int width, int height, int mineNum)
    {
        mBoard = new int[width, height];
        mWidth = width;
        mHeight = height;
        mMineNum = mineNum;
    }

    public ESectorInfo GetSectorInfoByCoordinate(int x, int y) 
    {
        return ESectorInfo.Empty; //юс╫ц
    }

}
