using JopipediaAPI.Data.DTO.Answer;

namespace JopipediaAPI.Data.DTO.Question;

public class SaveQuestionAndAnswersDTO
{ 
   public QuestionDTO? question { get; set; }
   public List<AnswerDTO>? answers { get; set; }
   public int? index { get; set; }
}