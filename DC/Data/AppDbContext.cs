using DC.Models;
using Microsoft.EntityFrameworkCore;

namespace DC.Data
{
  public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
  {
    public DbSet<AnswerModel> AnswerModel { get; set; }
    public DbSet<QuestionAnswerModel> QuestionAnswerModel { get; set; }
    public DbSet<QuestionModel> QuestionModel { get; set; }
    public DbSet<ResultModel> ResultModel { get; set; }
    public DbSet<StaffModel> StaffModel { get; set; }
    public DbSet<SurveyModel> SurveyModel { get; set; }
    public DbSet<SurveyQuestionModel> SurveyQuestionModel { get; set; }
    public DbSet<SurveyResultModel> SurveyResultModel { get; set; }
    public DbSet<UserAccountModel> UserAccountModel { get; set; }
  }
}