using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class CambiarLenguaje : MonoBehaviour
{

    int currentLang = 0;

    // Start is called before the first frame update
    void Start()
    {


        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[currentLang];

      //  LocalizationSettings.SelectedLocale         // idioma seleccionado
      while(LocalizationSettings.SelectedLocale != searcher && currentLang < LocalizationSettings.AvailableLocales.Locales.Count)
      {


            currentLang++;
            searcher = LocalizationSettings.AvailableLocales.Locales[currentLang];



      }




        //LocalizationSettings.AvailableLocales.Locales = new List<string>();



    }

    // Update is called once per frame
    public void NextLang()
    {


        currentLang++;


        if (currentLang >  LocalizationSettings.AvailableLocales.Locales.Count - 1)
        {
            currentLang = 0;


        }



        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];



    }
    public void PrevLang()
    {

        currentLang--;

        if(currentLang < 0)
        {
            currentLang = LocalizationSettings.AvailableLocales.Locales.Count - 1;


        }



        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales [currentLang];  




    }



}
