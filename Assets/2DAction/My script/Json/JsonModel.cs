using System.IO;
using UnityEditor;
using UnityEngine;

public static class JsonModel
{
    /// <summary>
    /// 指定されたパスからJsonファイルを読み込む関数
    /// </summary>
    /// <typeparam name="T">読み込みたいクラス</typeparam>
    /// <param name="path">読み込みたいデータのパス</param>
    /// <returns>読み込んだデータ</returns>
    public static T LoadJson<T>(string path)
    {
        using var _reader = new StreamReader(path, System.Text.Encoding.GetEncoding("UTF-8"));

        var _jsonStr = _reader.ReadToEnd();
        _reader.Close();

        Debug.Log($"通常ファイル読み込んだJsonファイルの内容{_jsonStr}");

        return JsonUtility.FromJson<T>(_jsonStr);
    }

    /// <summary>
    /// Jsonファイルを作る関数
    /// </summary>
    /// <param name="data">作りたいデータ</param>
    /// <param name="path">読み込みたいデータのパス</param>
    public static void CreateJson<T>(T data, string path)
    {
        using var _writer = new StreamWriter(path);

        var _jsonStr = JsonUtility.ToJson(data);

        Debug.Log($"作成したJsonファイルの内容{_jsonStr}\nパス{path}");

        _writer.Write(_jsonStr);
        _writer.Flush();
        _writer.Close();
    }
}
