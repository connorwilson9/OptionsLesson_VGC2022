using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class GameCode : MonoBehaviour
{
    public TilemapRenderer skyTiles;
    public TilemapRenderer spaceTiles;
    public SpriteRenderer spaceShip;
    public Button changeSpace;
    public Button changeSky;
    public Button changeShipDark;
    public Button changeShipLight;
    public Button exitGame;
    public Sprite darkShip;
    public Sprite lightShip;

    // Start is called before the first frame update
    void Start()
    {
        changeSky.onClick.AddListener(ChangeSky);
        changeSpace.onClick.AddListener(ChangeSpace);
        changeShipLight.onClick.AddListener(ChangeShipLight);
        changeShipDark.onClick.AddListener(ChangeShipDark);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSky(){

    }

    void ChangeSpace(){

    }   

    void ChangeShipLight(){

    } 
    
    void ChangeShipDark(){

    } 

}
