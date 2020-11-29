using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ballmovement : MonoBehaviour
{
    [SerializeField] string tag;
    [SerializeField] float stepsize =10f;
    [SerializeField] float speed=22f;
    [SerializeField] float speedSides = 5f;
    [SerializeField] string maxScore ="10";
    [SerializeField] Text scoreText;
    [SerializeField] int totalLevels;



    private Transform currentTransform = null;
    private Vector3 lastPosition;
    private bool isstrikecheck = false;
    private int counterRound = 1;
    private Vector3 ballPos;
    private Rigidbody myBody;




    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        ballPos = transform.position;
        currentTransform = transform;
        lastPosition = currentTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Mover();
        if (Mathf.Abs(lastPosition.z- currentTransform.position.z)<0.01&&lastPosition.z>ballPos.z+3)
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);

            for (var i = 0; i < gameObjects.Length; i++)
                Destroy(gameObjects[i]);
            if (scoreText.text.Equals(maxScore))
                isstrikecheck = true;
            if (isstrikecheck||counterRound==2)
            {
                if (SceneManager.GetActiveScene().buildIndex < totalLevels-1)
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                counterRound++;
                transform.position = ballPos;
                transform.rotation = Quaternion.identity;
                myBody.isKinematic = true;
            }
        }

        lastPosition = currentTransform.position;
    }

    void Mover()
    {
        
            float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
            Vector3 movementVector = new Vector3(horizontal, 0, 0) * speedSides * Time.deltaTime;
            transform.position += movementVector;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myBody.isKinematic = false;
            myBody.velocity = new Vector3(0, 0, speed);
        }
     
       
    }
      


}
