using System.Dynamic;

class Question
{
    private Random randQuesion = new Random();
    private List<string> _Question = new List<string>
    { "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
         "How did I see the hand of the Lord in my life today?",
         ""
    };

    public string GetQuestion()
    {
        int listIndex = randQuesion.Next(_Question.Count);
        return _Question[listIndex];
    }
 }