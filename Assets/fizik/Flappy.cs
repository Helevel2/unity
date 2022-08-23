using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum GameState
{
    isPlaying,
    GameOver,
    Ready
}
public class Flappy : MonoBehaviour
{
    
    [SerializeField] float acceleration = 9.81f;
    [SerializeField] float jumpVelocity = 1;
    [SerializeField] float minHeight, maxHeight;
    
    

    GameState state = GameState.Ready;
    float speed = 0;
    void FixedUpdate()
    {
        if (state==GameState.isPlaying)
            speed -= acceleration * Time.fixedDeltaTime;
    }
    void Update()
    {
        if (state== GameState.GameOver)
        {
            return;
        }
        if (Input.anyKeyDown)
        {
            state = GameState.isPlaying;
            speed += jumpVelocity;
        }
        if (state==GameState.isPlaying)
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);

        float y = transform.position.y;
        if (y < minHeight || y > maxHeight)
        {
           
            StartCoroutine(GameOver());
            
        }
    }
    IEnumerator GameOver()
    {
        Debug.Log("Game over");
        state = GameState.GameOver;
        yield return new WaitForSeconds(1);
        state = GameState.Ready;
        Vector3 p = transform.position;
        p.y = (minHeight + maxHeight) / 2;
        transform.position = p;
        speed = 0;

    }
}
