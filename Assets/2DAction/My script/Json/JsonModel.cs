using System.IO;
using UnityEditor;
using UnityEngine;

public static class JsonModel
{
    /// <summary>
    /// �w�肳�ꂽ�p�X����Json�t�@�C����ǂݍ��ފ֐�
    /// </summary>
    /// <typeparam name="T">�ǂݍ��݂����N���X</typeparam>
    /// <param name="path">�ǂݍ��݂����f�[�^�̃p�X</param>
    /// <returns>�ǂݍ��񂾃f�[�^</returns>
    public static T LoadJson<T>(string path)
    {
        using var _reader = new StreamReader(path, System.Text.Encoding.GetEncoding("UTF-8"));

        var _jsonStr = _reader.ReadToEnd();
        _reader.Close();

        Debug.Log($"�ʏ�t�@�C���ǂݍ���Json�t�@�C���̓��e{_jsonStr}");

        return JsonUtility.FromJson<T>(_jsonStr);
    }

    /// <summary>
    /// Json�t�@�C�������֐�
    /// </summary>
    /// <param name="data">��肽���f�[�^</param>
    /// <param name="path">�ǂݍ��݂����f�[�^�̃p�X</param>
    public static void CreateJson<T>(T data, string path)
    {
        using var _writer = new StreamWriter(path);

        var _jsonStr = JsonUtility.ToJson(data);

        Debug.Log($"�쐬����Json�t�@�C���̓��e{_jsonStr}\n�p�X{path}");

        _writer.Write(_jsonStr);
        _writer.Flush();
        _writer.Close();
    }
}
