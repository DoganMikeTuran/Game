using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    void Start(){
     print("Hello world");
}
  

    public void OnButtonClicked() {
        GameObject.Find("Cube2").GetComponent<Rigidbody>().AddForce(0, 200, 0);        
    }


    public void HelloWorld(){
    print("Hello world from button");
    
    }

}
