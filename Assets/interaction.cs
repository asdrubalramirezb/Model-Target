using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class interaction : MonoBehaviour
{
    // Slider que se usara para controlar la rotacion del objeto 
    public  Slider sliderRotacion; 
    // Variable que almacena el objeto 
    public GameObject GOAuto;

    // Array de materiales 
    public Material [] newColor;
    // Array que almacena  las diferentes partes del Auto
    GameObject[] partesAuto; 
    //Array temporal para almacenar los materiales del Mesh render 
    Material [] mats; 


   public void rotacion (){
       GOAuto.transform.rotation = Quaternion.Euler (0, sliderRotacion.value, 0);
   }

   public void cambiarColor (int color){
       // Buscar los objetos en la secenen a los cuales les voy a cambiar el color "TAG"
       partesAuto = GameObject.FindGameObjectsWithTag("colorear");
       // recorre todo el arreglo de partesAuto
       foreach(GameObject obj in partesAuto){
           //toma los materiales dentro del MEsh Renderer de cada objeto "partes auto", los los coloca dentro del array "mats" 
           mats=obj.GetComponent<Renderer>().materials; 
           mats[0]=newColor[color]; 
           obj.GetComponent<Renderer>().materials=mats; 
       }
      partesAuto=null; 
   }
 
}
