using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wordmanager2 : MonoBehaviour
{
    public List<Word2> words;

    public wordspawn2 wordspawn2;

    private bool hasactiveword;
    private Word2 activeword;


    public void Addword()
    {

        Word2 word= new Word2(Generador2.GetRandomWord(), wordspawn2.spawword2());

        words.Add(word);

    }


    public void Type(char letra)
    {
        if (hasactiveword)
        {
            if (activeword.Nextletra() == letra)
            {
                activeword.Typeletra();
            }

        }
        else
        {
            foreach (Word2 word in words)
            {
                if (word.Nextletra() == letra)
                {
                    activeword = word;
                    hasactiveword = true;
                    word.Typeletra();
                    break;
                }
            }
        }

        if (hasactiveword && activeword.Wordtype())
        {
            hasactiveword = false;
            words.Remove(activeword);
        }

    }

}

