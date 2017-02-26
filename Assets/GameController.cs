using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameController : MonoBehaviour {
     Button start;
     Button end;   
     Button answer1;
     Button answer2;
     Button answer3;
     Vector3 currentPositionEnd;
     Vector3 currentPositionAnswer1;
     Vector3 currentPositionAnswer2;
     Vector3 currentPositionAnswer3;
     Image Healthbar;
     float temphealth = 1f;
     List<string> questionlist = new List<string>();
    List<string> button1textlist = new List<string>();
    List<string> button2textlist = new List<string>();
    List<string> button3textlist = new List<string>();
    Text button1text;
    Text button2text;
    Text button3text;
    Text question;
    int count = 0;
    

     
     

    // Use this for initialization
    void Start () {
        questionlist.Add("Mikä on Ken-Saman lempikieli?");
        questionlist.Add("Mikä on Ken-Saman lempiase?");
        questionlist.Add("Onko tämä peli hyvä?");
        button1textlist.Add("Japani");
        button1textlist.Add("Katana");
        button1textlist.Add("On");
        button2textlist.Add("Englanti");
        button2textlist.Add("Revolveri");
        button2textlist.Add("Ehkä");
        button3textlist.Add("Suomi");
        button3textlist.Add("Nyrkit");
        button3textlist.Add("Ei");
        question = GameObject.Find("Question").GetComponent<Text>();
        start = GameObject.Find("Start").GetComponent<Button>();
        button1text = GameObject.Find("AnswerText1").GetComponent<Text>();
        button2text = GameObject.Find("AnswerText2").GetComponent<Text>();
        button3text = GameObject.Find("AnswerText3").GetComponent<Text>();
        end = GameObject.Find("End").GetComponent<Button>();
        answer1 = GameObject.Find("Answer1").GetComponent<Button>();
        answer2 = GameObject.Find("Answer2").GetComponent<Button>();
        answer3 = GameObject.Find("Answer3").GetComponent<Button>();
        start.onClick.AddListener(() => StartGame());
        end.onClick.AddListener(() => EndGame());
        answer1.onClick.AddListener(() => Checker(answer1));
        answer2.onClick.AddListener(() => Checker(answer2));
        answer3.onClick.AddListener(() => Checker(answer3));
        //tällä siirretään nappulat pois näkyvistä ja annetaan niille myös paikka johon palata kun metodia kutsutaan
        currentPositionEnd = end.transform.position = new Vector3 (217,-139);
        end.transform.localPosition = new Vector3(1000,1000);
        currentPositionAnswer1 = answer1.transform.position = new Vector3(-2, 61);
        answer1.transform.localPosition = new Vector3(1000, 1000);
        currentPositionAnswer2 = answer2.transform.position = new Vector3(0, 0);
        answer2.transform.localPosition = new Vector3(1000, 1000);
        currentPositionAnswer3 = answer3.transform.position = new Vector3(-2, -64);
        answer3.transform.localPosition = new Vector3(1000, 1000);
        Healthbar = GameObject.Find("Healthbar").GetComponent<Image>();
        question.text = "";
    
        
        
        




    }
    void getPressed()
    {
        Debug.Log("toimiiko?");
    }
    void CorrectAnswer()
    {
        count++;
        if (count == 1)
        {
            answer1.transform.localPosition = new Vector3(-2, -64);
            answer2.transform.localPosition = new Vector3(-2, 61);
            answer3.transform.localPosition = new Vector3(0, 0);
        } else if (count == 2)
        {
            answer1.transform.localPosition = new Vector3(0, 0);
            answer2.transform.localPosition = new Vector3(-2, -64);
            answer3.transform.localPosition = new Vector3(-2, 61);
        }
        if (count == 3)
        {
            
            EndGame();
        }

        question.text = questionlist[count];
        button1text.text = button1textlist[count];
        button2text.text = button2textlist[count];
        button3text.text = button3textlist[count];
        

    }
    void WrongAnswer()
    {
        temphealth = temphealth - 0.25f;
        if (temphealth ==0f)
        {
            EndGame();
        }
    }
    //Katsoo painettiinko answer 1 nappia
    void Checker(Button right)
    {
        if (right == answer1)
        {
            CorrectAnswer();
        } else {
            WrongAnswer();

          }


    }
        
       
    //kun start nappia painaa niin se häviää ja muut nappulat tulevat esiin
    void StartGame()
    {

        question.text = questionlist[0];
        end.transform.localPosition = currentPositionEnd;
        answer1.transform.localPosition = currentPositionAnswer1;
        answer2.transform.localPosition = currentPositionAnswer2;
        answer3.transform.localPosition = currentPositionAnswer3;
        start.transform.localPosition = new Vector3(1000, 1000);
    }
    // kun end nappia painaa niin kaikki nappulat katoavat ja start tulee esiin
    void EndGame()
    {
        question.text = "";
        button1text.text = button1textlist[0];
        button2text.text = button2textlist[0];
        button3text.text = button3textlist[0];
        count = 0;
        end.transform.localPosition = new Vector3(1000, 1000);
        answer1.transform.localPosition = new Vector3(1000, 1000);
        answer2.transform.localPosition = new Vector3(1000, 1000);
        answer3.transform.localPosition = new Vector3(1000, 1000);
        start.transform.localPosition = new Vector3(-217, -139);
        temphealth = 1;
    }
    


    // Update is called once per frame
    void Update () {
        
        
        Healthbar.fillAmount = temphealth;
        
       
	}
}
