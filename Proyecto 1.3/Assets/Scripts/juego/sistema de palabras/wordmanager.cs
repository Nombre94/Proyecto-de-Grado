using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wordmanager : MonoBehaviour
{
   public  List<Word> words;

    public wordspawn wordspawn;

    private bool hasactiveword;
    private Word activeword;


    public void Addword()
    {

        Word word = new Word(Generador.GetRandomWord(), wordspawn.spawword());

        words.Add(word);
    
    }


    public void Type(char letra)
    {
         if (hasactiveword)
        {
            if (activeword.Nextletra()==letra)
            {
                activeword.Typeletra();
            }

        }else
        {
            foreach(Word word in words)
            {
                if (word.Nextletra()==letra)
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
