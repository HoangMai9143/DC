using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using DC.Models;

using MudBlazor;

namespace DC.Components.Dialog
{
  public partial class QuestionEditDialog
  {
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    [Parameter] public int QuestionId { get; set; } // Question ID to edit

    private QuestionModel currentQuestion = new(); // Current question to edit
    private List<AnswerModel> currentAnswers = []; // Current answers of the question

    protected override async Task OnInitializedAsync()
    {
      await LoadQuestion(QuestionId);
    }

    private async Task SaveChanges()
    {
      try
      {
        if (currentQuestion == null || currentAnswers == null)
        {
          sb.Add("Error: Question or answers cannot be null.", Severity.Error);
          return;
        }

        if (currentQuestion.Id == 0)
        {
          await appDbContext.Set<QuestionModel>().AddAsync(currentQuestion);
        }
        else
        {
          appDbContext.QuestionModel.Update(currentQuestion);
        }

        await appDbContext.SaveChangesAsync();

        // Remove answers that are no longer in the list
        var existingAnswers = await appDbContext.AnswerModel
        .Where(a => a.QuestionId == currentQuestion.Id)
        .ToListAsync();

        foreach (var existingAnswer in existingAnswers)
        {
          if (!currentAnswers.Exists(a => a.Id == existingAnswer.Id))
          {
            appDbContext.AnswerModel.Remove(existingAnswer);
          }
        }

        // Add or update current answers
        foreach (var answer in currentAnswers)
        {
          answer.QuestionId = currentQuestion.Id;
          if (answer.Id == 0)
          {
            await appDbContext.AnswerModel.AddAsync(answer);
          }
          else
          {
            appDbContext.AnswerModel.Update(answer);
          }
        }

        await appDbContext.SaveChangesAsync();
        sb.Add("Changes saved successfully.", Severity.Success);
        // Close the dialog
        MudDialog.Close(DialogResult.Ok(true));
      }
      catch (Exception ex)
      {
        sb.Add($"Error saving changes: {ex.Message}", Severity.Error);
      }
    }

    private void AddNewAnswer()
    {
      currentAnswers.Add(new AnswerModel
      {
        QuestionId = currentQuestion.Id,
        Points = 1
      });
    }

    private void RemoveAnswer(AnswerModel answer)
    {
      currentAnswers.Remove(answer);
      if (answer.Id != 0)
      {
        appDbContext.AnswerModel.Remove(answer);
      }
    }

    private async Task LoadQuestion(int questionId)
    {
      currentQuestion = await appDbContext.QuestionModel
      .Include(q => q.Answers)
      .FirstOrDefaultAsync(q => q.Id == questionId);

      if (currentQuestion != null)
      {
        currentAnswers = currentQuestion.Answers.ToList();
      }
      else
      {
        currentQuestion = new QuestionModel();
        currentAnswers = new List<AnswerModel>();
      }
    }

    void Cancel() => MudDialog.Cancel();
  }
}