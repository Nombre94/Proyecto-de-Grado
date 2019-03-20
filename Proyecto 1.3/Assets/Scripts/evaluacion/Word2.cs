using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Word2
{
    public string word;
    private int typeindex;

    worddisplay2 display;

    public Word2(string _word, worddisplay2 _display)
    {
        word = _word;
        typeindex = 0;

        display = _display;
        display.setword(word);
    }

    public char Nextletra()
    {
        return word[typeindex];
    }

    public void Typeletra()
    {
        typeindex++;

        display.removerletra();
    }

    public bool Wordtype()
    {
        bool wordtype = (typeindex >= word.Length);
        if (wordtype)
        {
            display.removerword();
        }

        return wordtype;

    }


}
