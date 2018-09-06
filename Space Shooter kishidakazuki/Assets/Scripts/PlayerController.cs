using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Boundary{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerController : MonoBehaviour {
    
    public float speed;
    public Boundary boundary;
    public float tilt;
    public float yFix = 0.0f;
    public GameObject RedGarbageBag;
    public GameObject BlueGarbageBag;
    public GameObject GreenGarbageBag;
    public int getWasteScore;
    public Sprite moeru;
    public Sprite moenai;
    public Sprite bin;
    public Sprite can;
    public Image mark1;
    public Image mark2;
    public Text HP;
    public int life;

    private Rigidbody rb;
    private float nextFire;
    private GameController gameController;
    private Replacement red, blue, green;

    void Start(){
        
        rb = GetComponent<Rigidbody>();
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null){

            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null){

            Debug.Log("Cannot find 'GameController' script");
        }
        red = RedGarbageBag.GetComponent<Replacement>();
        blue = BlueGarbageBag.GetComponent<Replacement>();
        green = GreenGarbageBag.GetComponent<Replacement>();

        UpdateHP(0);

    }

    void FixedUpdate(){
        
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = 
            new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 
            yFix,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        //横移動のとき，傾ける
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }


    void Update(){
        Vector3 playerBack = new Vector3(rb.position.x, 0.0f, 5.0f);
        if (Input.GetKeyDown(KeyCode.Z) && !red.isSelect){
            red.Updown(true, playerBack);
            blue.Updown(false, playerBack);
            green.Updown(false, playerBack);
        }else if (Input.GetKeyDown(KeyCode.X) && !blue.isSelect){
            red.Updown(false, playerBack);
            blue.Updown(true, playerBack);
            green.Updown(false, playerBack);
        }else if (Input.GetKeyDown(KeyCode.C) && !green.isSelect){
            red.Updown(false, playerBack);
            blue.Updown(false, playerBack);
            green.Updown(true, playerBack);
        }

        // Spriteを表示しないようにする(とりあえず)
        mark1.enabled = false;
        mark2.enabled = false;

        if(red.isSelect){ // 燃えるゴミ
            mark1.sprite = moeru;
            mark1.enabled = true;
        }else if(blue.isSelect){ // 燃えないゴミ
            mark1.sprite = moenai;
            mark1.enabled = true;
        }else if(green.isSelect){ // びんかん
            mark1.sprite = bin;
            mark2.sprite = can;
            mark1.enabled = true;
            mark2.enabled = true;
        }
    }

    void OnTriggerEnter(Collider other){

        if (other.tag == "Combustible"){
            if(red.isSelect){
                gameController.AddScore(getWasteScore);
                red.Expansion();
                Destroy(other.gameObject);
            }else{
                UpdateHP(1);
                Destroy(other.gameObject);
            }
        }

        if (other.tag == "Nonflammable"){
            if (blue.isSelect){
                gameController.AddScore(getWasteScore);
                blue.Expansion();
                Destroy(other.gameObject);
            }else{
                UpdateHP(1);
                Destroy(other.gameObject);
            }
        }

        if ((other.tag == "Bottle" || other.tag == "Can")){
            if (green.isSelect){
                gameController.AddScore(getWasteScore);
                green.Expansion();
                Destroy(other.gameObject);
            }else{
                UpdateHP(1);
                Destroy(other.gameObject);
            }
        }
    }

    void UpdateHP(int damage){
        life -= damage;
        HP.text = "× " + life;
    }
}
