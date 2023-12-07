using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IssacMovement : MonoBehaviour
{
    [SerializeField]
    private Powerupdata currentpowerup;
    [SerializeField]
    private List<Powerupdata> AvaiablePowerups = new List<Powerupdata>();
    private IssacControls playerActions;

    public GameObject tear;

    public bool hasbrim,haswiz = false;

    public GameObject brim;

    public GameObject doublewiz;


    private void Awake()
    {
        playerActions = new IssacControls();

        playerActions.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      /*  if (hasbrim == false)
        {
           // hasbrim = GameObject.Find("Powerup").GetComponent<Powerup>().hasbrim;
        }
       */
        Vector2 moveVec = playerActions.Issac.Move.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveVec.x, 0, moveVec.y) * 7f * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveVec = context.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveVec.x, moveVec.y, 0) * 7f * Time.deltaTime);
    }




    public void SwitchWeapon(PowerupType powerup)
    {
        for (int i = 0; i < AvaiablePowerups.Count; i++)
        {
            if (powerup == AvaiablePowerups[i].PowerType)
                currentpowerup = AvaiablePowerups[i];
        }
    }

    public void Shoot()
    {

    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
           // GameObject go = Instantiate(tear.gameObject, transform.position, Quaternion.identity);
            //go.GetComponent<TearShot>().player = this;

            Debug.Log("Player has Shot");

            if (hasbrim == false && haswiz == false)
            {
                GameObject go = Instantiate(tear.gameObject, transform.position, tear.transform.rotation);
                go.GetComponent<TearShot>().player = this;
            }
            if (hasbrim == true && haswiz == false)
            {
                StartCoroutine(BrimHold());
                GameObject go = Instantiate(brim.gameObject, transform.position,brim.transform.rotation);
                go.GetComponent<Brimstone>().player = this;
            }

            if(hasbrim == false && haswiz == true)
            {
                StartCoroutine(BrimHold());
                for (int i = 0; i < 2; i++)
                {
                    //% is a modulo. It is checking if i is even or odd. the ? is  ternary conditional operator is a way of doing a one line if statement. If i is even it send it to left side of the semi colon. If it's false it sends it into the right side of the semi colon.

                    GameObject go = Instantiate(doublewiz.gameObject, transform.position, doublewiz.transform.rotation);
                    go.GetComponent<DoubleWiz>().player = this;
                    go.GetComponent<DoubleWiz>().direction.x = i % 2 == 0 ? go.GetComponent<DoubleWiz>().direction.x : -go.GetComponent<DoubleWiz>().direction.x;
                }
           
            }

        }

      
    }

    private IEnumerator BrimHold()
    {
        int brim = 30;
        for (int i = 0; i < brim; i++)
        {
            yield return new WaitForSeconds(.1f);
        }
        yield return null;
        

    }

  

}