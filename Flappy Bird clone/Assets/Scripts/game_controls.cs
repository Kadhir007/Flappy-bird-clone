using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class game_controls : MonoBehaviour
{
    
    private AudioSource wav;
    public static game_controls instance;
    public GameObject gameovertext;
    public bool endgame = false;
    private int score = 0;
    private TextMesh score_text;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        wav = GetComponent<AudioSource>();
        score_text = GetComponent<TextMesh>();
        
    }
    
   

    public void bird_died()
    {
        if (!endgame)
             {
               wav.Play();
            }


        endgame = true;
        StartCoroutine(time());
        




    }
    public void birdscore()
    {
        score = score + 1;
        score_text.text = score.ToString();
    }
    public IEnumerator time()
    {
        yield return new WaitForSeconds(2.5f);
        gameovertext.SetActive(true);
        

    }
}
