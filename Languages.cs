using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Languages : MonoBehaviour
{

    public enum LanguagesTags{
        es,en
    }

    public enum TextLanguageTag{
        welcome,exit,start,
    }

    
    public static void SetLanguages(LanguagesTags lang){
        var textsLaguagues = GameObject.FindObjectsOfType(typeof(TextLanguage));
        foreach(TextLanguage tl in textsLaguagues){
           if(TextTagLanguage.ContainsKey(tl.LanguageTag)){ 
               tl.GetComponent<Text>().text = TextTagLanguage[tl.LanguageTag][lang];
           }
        }
    }

    private static Dictionary<LanguagesTags,string> InsterLaguage(string es,string en){
        return new Dictionary<LanguagesTags,string>(){{LanguagesTags.es,es},{LanguagesTags.en,en}};
    }

    public static Dictionary<TextLanguageTag,Dictionary<LanguagesTags,string>> TextTagLanguage = new Dictionary<TextLanguageTag, Dictionary<LanguagesTags,string>>(){
        {TextLanguageTag.welcome,         InsterLaguage("Bienvenido","Welcome")},
        {TextLanguageTag.exit,            InsterLaguage("Salir","Exit")},
        {TextLanguageTag.start,           InsterLaguage("Iniciar Sesion","Start")},
    };

}
