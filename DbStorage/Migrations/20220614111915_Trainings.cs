using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbStorage.Migrations
{
    public partial class Trainings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainingDoId",
                table: "Exercises",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDoId = table.Column<int>(type: "int", nullable: false),
                    ExerciseDoId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseTrainings_Exercises_ExerciseDoId",
                        column: x => x.ExerciseDoId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTrainings_Trainings_TrainingDoId",
                        column: x => x.TrainingDoId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TrainingDoId",
                table: "Exercises",
                column: "TrainingDoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainings_ExerciseDoId",
                table: "ExerciseTrainings",
                column: "ExerciseDoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainings_TrainingDoId",
                table: "ExerciseTrainings",
                column: "TrainingDoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Trainings_TrainingDoId",
                table: "Exercises",
                column: "TrainingDoId",
                principalTable: "Trainings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Trainings_TrainingDoId",
                table: "Exercises");

            migrationBuilder.DropTable(
                name: "ExerciseTrainings");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_TrainingDoId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "TrainingDoId",
                table: "Exercises");
        }
    }
}
