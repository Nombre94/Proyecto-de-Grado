using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// en este script se crea la lista de palabras que se mostraran al usuario 
public class Generador2 : MonoBehaviour
{
    private static string[] lista = { "import java.lang.Math; \nimport javax.swing.*; \npublic class hipotenus { \ndouble CalculaHipotenusa(double cateto1,double cateto2) { \ndouble hipotenusa; \nhipotenusa=Math.pow((Math.pow(cateto1,2)+Math.pow(cateto2,2)),0.5); \nreturn hipotenusa; }", "public static void main(String[] args) { \ndouble hipotenusa=0; \nDSCHipotenusa catetos = new DSCHipotenusa(); \nString cadena; \ndouble cateto1=0,cateto2=0; \ncadena=JOptionPane.showInputDialog(\"Ingrese Cateto 1:\"); \ncateto1=Double.parseDouble(cadena); \ncadena=JOptionPane.showInputDialog( \"Ingrese Cateto 2:\"); \ncateto2=Double.parseDouble(cadena);", "public class MultiDiv { \ndouble Multiplica(double var){ \ndouble multi; \nmulti=var*5; \neturn multi; } \ndouble Divide(double var) { \ndouble div; \ndiv=var/7; \nreturn div; }", "if (args.length==0) { \nSystem.out.println(\"Debe ingresar un argumento.\"); } \nelse { \nfor(int i=0;i<args.length;i++) { \nj=Double.parseDouble(args[i]); \ndouble multip=variable.Multiplica(j); \ndouble divi=variable.Divide(j); \nSystem.out.println(j+\"/7=\"+divi); \nSystem.out.println(j+\"x5=\"+multip); } }", "public class SyGPiramideNumerica { \npublic static void main(String[] arg) { \nint limite=0; \nlimite=Integer.parseInt(arg[0]); \nfor(int i=1; i<=limite;i++) { \nfor(int j=1;j<=i;j++) { \nSystem.out.print(i); } \nSystem.out.println(\"\"); } } }"};

    public static string GetRandomWord()
    {
        int random = Random.Range(0, lista.Length);
        string word = lista[random];
        GameManager.codigo = random;
        return word;
    }

}
