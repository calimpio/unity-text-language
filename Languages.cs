using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Languages : MonoBehaviour
{

    public enum LanguagesTags
    {
        es, en
    }

    public enum TextLanguagesTags
    {
        welcome, exit, start,
    }


    public static Dictionary<TextLanguagesTags, Dictionary<LanguagesTags, string>> TextTagLanguage = new Dictionary<TextLanguagesTags, Dictionary<LanguagesTags, string>>()
    {
        {TextLanguagesTags.welcome,         InsterLaguage("Bienvenido","Welcome")},
        {TextLanguagesTags.exit,            InsterLaguage("Salir","Exit")},
        {TextLanguagesTags.start,           InsterLaguage("Iniciar Sesion","Start")},
    };


    public static void SetLanguages(LanguagesTags lang)
    {
        var textsLaguagues = GameObject.FindObjectsOfType(typeof(TextLanguage));
        foreach (TextLanguage tl in textsLaguagues)
        {
            if (TextTagLanguage.ContainsKey(tl.LanguageTag))
            {
                var text = TextTagLanguage[tl.LanguageTag][lang];

                if (tl.GetComponent<Text>() != null)
                {
                    tl.GetComponent<Text>().text = text;
                }
                else
                if (tl.GetComponent<TextMesh>() != null)
                {
                    tl.GetComponent<TextMesh>().text = text;
                }
                else
                if (tl.GetComponent<TMPro.TextMeshPro>() != null)
                {
                    tl.GetComponent<TMPro.TextMeshPro>().text = text;
                }
                else
                if (tl.GetComponent<TMPro.TextMeshProUGUI>() != null)
                {
                    tl.GetComponent<TMPro.TextMeshProUGUI>().text = text;
                }
                else
                if (tl.GetComponentInChildren<Text>() != null)
                {
                    tl.GetComponentInChildren<Text>().text = text;
                }
                else
                if (tl.GetComponentInChildren<TMPro.TextMeshProUGUI>() != null)
                {
                    tl.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = text;
                }                
                else
                if (tl.GetComponentInChildren<TMPro.TextMeshPro>() != null)
                {
                    tl.GetComponentInChildren<TMPro.TextMeshPro>().text = text;
                }
            }
        }
    }

    private static Dictionary<LanguagesTags, string> InsterLaguage(string es, string en)
    {
        return new Dictionary<LanguagesTags, string>() { { LanguagesTags.es, es }, { LanguagesTags.en, en } };
    }

    

}
