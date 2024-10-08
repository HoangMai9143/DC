﻿// <auto-generated />
using System;
using DC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DC.Models.AnswerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("answer_text");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("points");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("question_id");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("DC.Models.QuestionAnswerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnswerId")
                        .HasColumnType("int")
                        .HasColumnName("answer_id");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("question_id");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int")
                        .HasColumnName("survey_id");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("StaffId");

                    b.HasIndex("SurveyId");

                    b.ToTable("QuestionAnswer");
                });

            modelBuilder.Entity("DC.Models.QuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnswerType")
                        .HasColumnType("int")
                        .HasColumnName("answer_type");

                    b.Property<string>("QuestionContext")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("question_context");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("DC.Models.ResultModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("note");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("question_id");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int")
                        .HasColumnName("survey_id");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("StaffId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("DC.Models.StaffModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("department");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("full_name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("DC.Models.SurveyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("created_date");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("end_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("start_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("DC.Models.SurveyQuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("question_id");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int")
                        .HasColumnName("survey_id");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyQuestion");
                });

            modelBuilder.Entity("DC.Models.SurveyResultModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("FinalGrade")
                        .HasColumnType("float")
                        .HasColumnName("final_grade");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("note");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int")
                        .HasColumnName("survey_id");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyResult");
                });

            modelBuilder.Entity("DC.Models.UserAccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("UserAccount");
                });

            modelBuilder.Entity("DC.Models.AnswerModel", b =>
                {
                    b.HasOne("DC.Models.QuestionModel", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("DC.Models.QuestionAnswerModel", b =>
                {
                    b.HasOne("DC.Models.AnswerModel", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId")
                        .IsRequired();

                    b.HasOne("DC.Models.QuestionModel", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .IsRequired();

                    b.HasOne("DC.Models.StaffModel", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .IsRequired();

                    b.HasOne("DC.Models.SurveyModel", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");

                    b.Navigation("Staff");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("DC.Models.ResultModel", b =>
                {
                    b.HasOne("DC.Models.QuestionModel", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DC.Models.StaffModel", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DC.Models.SurveyModel", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Staff");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("DC.Models.SurveyQuestionModel", b =>
                {
                    b.HasOne("DC.Models.QuestionModel", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DC.Models.SurveyModel", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("DC.Models.SurveyResultModel", b =>
                {
                    b.HasOne("DC.Models.StaffModel", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DC.Models.SurveyModel", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("DC.Models.QuestionModel", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
