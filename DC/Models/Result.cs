using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DC.Models
{
  [Table("result")]
  public record Result
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("survey_id")]
    public int SurveyId { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("question_id")]
    public int QuestionId { get; set; }

    [Column("grade")]
    public int Grade { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [ForeignKey("SurveyId")]
    public Survey? Survey { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }

    [ForeignKey("QuestionId")]
    public Question? Question { get; set; }
  }
}