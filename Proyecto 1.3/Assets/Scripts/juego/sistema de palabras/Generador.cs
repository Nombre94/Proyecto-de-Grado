using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// en este script se crea la lista de palabras que se mostraran al usuario 
public class Generador : MonoBehaviour
{
    private static string[,] lista = { { "import", "java.util", "Scanner;", "public", "class", "ParImpar {", "static", "void main", "String[]", "ARGS {", "new Scanner", "(System.in);", "System.", "out.print", "nextInt();", "int numero", "if()", "else {}", "numero == 0", "Scanner Leer" }, 
                                       {"static void","CONTADOR","System"," for()","i = 1; ","i <= numero","i++","static","public","System.out.","if()","CONTADOR <= 2","numero % I","System.","nextInt","(i<2)","util.Scanner;","System.in","Scanner","else {}"},
                                       {"Fibonacci","String[]","ARGS","A = -1;"," C = A + B;","System.out","public","class","if()","for()","i = 1;","i <= limite","Scanner","java.util.","void main"," B = 1;","(C +\"\");","A = B;","nextInt();","else {}"},
                                       {"if()","a<b","&& b<c","else if ()","System.out","int a=0;","public","static","length","else{}","DSCOrden","variable =","args.","a=Integer.","parseInt()","args[0]","(a,b,c)","void main","for()","out.println"},
                                       {"public class","static int","A=10;","int z=0;","vectorA[i]","for(i=0)","i<vectorA.length","Math.random()","new int[A];","elemA=0;","static void","B.length","()*100+1","int vectorA[]","=(int)","else if()","if() {}","for() {}"," elemA++;"," elemA=0;"},
                                       {"static void","Arreglo();","imprimir();","compara();","String[] args","System.out.print","\"B\"+\"[\"+i+\"]=","+vectorB[i]+\"\n\");"," for(int i=0;i","<vectorB.length","for(i=0;i<x;i++)","vectorA.length","java.text.","impleDateFormat;","java.util.Date;","ParseException;","SimpleDateFormat","int dias=(int)","dateFormat.parse","throws"},
                                       {"public class","int i=1,impar=1;"," String coma;","  if (i==2*Impares-1)"," while(i<=2*Impares-1)","coma=\", \";","(int i,String coma)","System.out.print","Integer.parseInt","if(args.length>1)","else if(Impares<=0)","(args[0]);","(String[] args)","if(args.length==0)","j=Integer.parseInt","i+=2;"," a[i]=(i+1);","b=a[i];","public static void","int i=1,den=1;"}
                                     } ;

    public static string GetRandomWord ()
    {
        int random = Random.Range(0, 20);
        int unico = 0;

        if (GameManager.nivel == 0 & GameManager.random==0)
        {
            int random2 = Random.Range(0, 4);
            unico = random2;
            GameManager.random = 1;
        }
        if (GameManager.nivel == 1 & GameManager.random == 0)
        {
            int random2 = Random.Range(4, 6);
            unico = random2;
            GameManager.random = 1;
        }

       
        string word = lista[unico, random];

        return word;
    }
	
}
