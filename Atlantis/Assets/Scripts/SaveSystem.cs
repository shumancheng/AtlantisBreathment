using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveGame(int indexCurrentScene)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Game.infos";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(indexCurrentScene);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static GameData LoadGame()
    {
        string path = Application.persistentDataPath + "/Game.infos";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;

        }
        else
        {
            SaveGame(0);
            return LoadGame();
        }
    }
}

