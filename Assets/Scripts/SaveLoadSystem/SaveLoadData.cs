using System;
using System.Collections.Generic;

[Serializable]
public class SaveLoadData
{
    public StoredValue<int> MaxScore;

    public SaveLoadData()
    {
        MaxScore = new StoredValue<int>(0);
    }
}