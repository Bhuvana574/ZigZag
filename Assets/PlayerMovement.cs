using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;// 
    public float playerSpeed;
    public GameObject particleEffectsPrefab;
    [SerializeField]
    int score = 0;
    public Text scoreText;
   public  Canvas canvas;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

            if (Input.GetMouseButtonDown(0))
        {
            if (direction == Vector3.forward)
            {
                direction = Vector3.left;
                
            }
            else
            {
                direction = Vector3.forward;
               
            }
             score = score + 1;
           Debug.Log("score:  " + score);
            scoreText.text = "Score:" + score;

        }

        transform.Translate(direction * playerSpeed * Time.deltaTime);
        if(transform.position.y<=0)
        {
            canvas.gameObject.SetActive(true);
            //animator.SetTrigger("Dead");
            
        }
      
    }


   
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Pickup")
        {
            score = score + 5;
            Debug.Log("score:  " + score);
            scoreText.text = "Score:" + score;
            other.gameObject.SetActive(false);
            Instantiate(particleEffectsPrefab, transform.position, Quaternion.identity);
        }
        
    }
   
}
