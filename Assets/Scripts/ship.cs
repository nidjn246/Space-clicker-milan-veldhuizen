using UnityEngine;

public class shipmovement : MonoBehaviour
{
    [SerializeField] private float speedX;

    [SerializeField] private float resetXposition;
    private float shipWidth;

    private GameManager game;
    private float position;
    [SerializeField] int scoreAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        game = FindFirstObjectByType<GameManager>();

     

        shipWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
   
        transform.position = transform.position + new Vector3(speedX * Time.deltaTime, 0f, 0f);

        if (transform.position.x + (shipWidth / 2f) < 0)
        {
            transform.position = new Vector3(resetXposition, transform.position.y, transform.position.z);
            game.AddScore(-1);
        }
    }
    private void OnMouseDown()
    {
       float randomY = Random.Range(-4.0f, 4.0f);

        transform.position = new Vector3(resetXposition, randomY, transform.position.z);

        game.AddScore(scoreAmount);
    }
}
