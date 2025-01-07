using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEnglishModeEnabled = table.Column<bool>(type: "bit", nullable: false),
                    NativeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LocationCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NativeAboutMe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    HasEnglishAboutMe = table.Column<bool>(type: "bit", nullable: false),
                    EnglishAboutMe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Institute = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NativeDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NativeDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experience_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NativeDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedia_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User_Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Skill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Skill_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("01965419-f26a-41a5-94ba-d996d4f1a15f"), "TypeScript", 0 },
                    { new Guid("01bff10b-52a7-4b57-ad0f-0f133152a715"), ".NET WPF", 1 },
                    { new Guid("0a5a8fb2-c215-4af8-aa16-b8e8d8d3f00a"), "Bootstrap", 0 },
                    { new Guid("13dad750-ff04-41c6-88dc-7c63a8d92253"), "C#", 1 },
                    { new Guid("2a5c60aa-11e9-47f4-89a6-614d4e60bcbb"), "Fluent API", 1 },
                    { new Guid("4d57dfff-a8ec-44d0-87d1-0715811a79e4"), "Java Spring", 1 },
                    { new Guid("51773eef-bce4-49d5-9d81-a2d2c37d443b"), "JWT", 2 },
                    { new Guid("52a44d73-4f89-4c1c-a75d-14d0628ab909"), "Middlewares", 1 },
                    { new Guid("5666c5f5-3909-4451-b389-e036c088115a"), "Python", 1 },
                    { new Guid("591db0f6-11a5-4e78-bdd2-f3b12453e0de"), "Vitest", 0 },
                    { new Guid("59a1fd14-d980-400e-98e9-a1193f10f59f"), ".NET API", 1 },
                    { new Guid("61243c4e-e7ef-4d20-8af8-700f46806840"), "POO", 2 },
                    { new Guid("634694e0-512b-454d-9981-79930220821f"), "Angular", 0 },
                    { new Guid("6d0b4661-d4ef-4c6f-841a-cab0ef99865f"), "Java", 1 },
                    { new Guid("7a116620-167f-492a-bfcc-64cf7508ee88"), "CSS", 0 },
                    { new Guid("7cee6703-8006-447f-a5f9-2739153eaec9"), "React", 0 },
                    { new Guid("7ea656a8-14a6-4237-8277-995aec5c1955"), "SQL", 1 },
                    { new Guid("82747309-dd6d-4709-ab40-03a492eeb39c"), "Entity Relationship Diagram", 2 },
                    { new Guid("82925956-b209-4a21-ac0f-994c16c851da"), "Testing library", 0 },
                    { new Guid("8359daf2-cc0d-4e03-9baa-72e326f51488"), "MS SQL Server", 1 },
                    { new Guid("86278975-69b0-4f93-85ec-2dcfc580a35f"), "Git", 2 },
                    { new Guid("897ea43f-bb82-4520-8092-87078f4d9668"), "JavaScript", 0 },
                    { new Guid("af9ab891-c034-47c0-a626-13d2ed509d03"), ".NET CORE 6", 1 },
                    { new Guid("b1dc9295-e48d-4def-aece-a9fec1e835f3"), "Node", 2 },
                    { new Guid("b92ee2a1-1b20-494d-8226-774f193026a6"), "Migrations", 1 },
                    { new Guid("be8a0b50-4968-4321-af62-e38a78a1fc05"), "TailwindCss", 0 },
                    { new Guid("c99311bf-a884-45f2-bc3f-f8a7ee094833"), "HTML", 0 },
                    { new Guid("cb322319-2b06-43a2-bd21-e42a7b8c878b"), "REST API", 2 },
                    { new Guid("cee20429-7bb4-4fcf-ba73-5b9d94d6ae72"), "MySql", 1 },
                    { new Guid("ea945c78-99c8-483d-8e3c-1207d5e2b92e"), "UML", 2 },
                    { new Guid("ec5ff3db-1eb7-4de7-a434-9d3c1cee27b6"), "Linux", 2 },
                    { new Guid("ecb0514d-3cd4-4c8a-8b72-875cadda5e92"), "Redux Toolkit", 0 },
                    { new Guid("ecf0f4a4-4db2-4cb5-88e3-28bcb7b5e22b"), "React Router", 0 },
                    { new Guid("eec9860d-4f68-4ecf-8283-944211113d0d"), "Vite", 0 },
                    { new Guid("f3c82a6e-3625-4f8d-ae73-bad613988c4d"), "Scrum", 2 },
                    { new Guid("fcff6f01-948b-4bc0-a282-5cdd88e4f064"), "Entity Framework", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Status", "Username" },
                values: new object[] { "p7EW1FzwW5hgFi4YTV1mmdHTAnm1", new DateTime(2024, 12, 18, 9, 37, 48, 291, DateTimeKind.Local).AddTicks(4667), "tiagoramirez2001@gmail.com", "I'm Fullstack Developer with 1 year of experience in the IT area.\n\nMy main stack: React.js + Typescript + Node.js + .NET 6 API + SQL Server", "FullStack Dev. || React + Typescript + .NET 6 + SQL Server + Node.js || Student in Systems Engineering - UTN 🇦🇷", true, true, true, "Argentina", "C.A.B.A.", "Tiago Alberto Ramirez Marchisio", "Soy Fullstack Developer con 1 año de experiencia en el área de TI.\n\nMi stack principal: React.js + Typescript + Node.js + .NET 6 API + SQL Server", "FullStack Dev. || React + Typescript + .NET 6 + SQL Server + Node.js || Ing. en Sistemas de Información - UTN 🇦🇷", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("26a9f437-e319-4218-aa44-140161b22431"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "English classes. At the end we took the First Certificate in English exam (Cambridge Institute). My level was: B2.", true, "Instituto Nuestra Sra del Huerto - Cambridge", false, "Clases de ingles. Al final rendimos el examen First Certificate in English (Instituto Cambridge). Mi nivel fue: B2.", new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", 3, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3a8b2385-8057-4556-b447-9affc41021c6"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topics:\n- Web Development and Applications (Introduction)\n- Static Front End Development (HTML, CSS, BOOTSTRAP, JavaScript y TypeScript)\n- Dynamic Front End Development (Angular)\n- BACKEND Development (MySQL + Java Spring)\n- Entity Relationship Diagram\n- JWT\n- DevOps", true, "Argentina Programa - INTI", false, "Temas:\n- Introducción a Desarrollo Web y Aplicaciones\n- Desarrollo Front End Estático (HTML, CSS, BOOTSTRAP, JavaScript y TypeScript)\n- Desarrollo Front End Dinámico (Angular)\n- Desarrollo Back End (MySQL+ Java Spring)\n- Diagrama Entidad Relación\n- JWT\n- DevOps", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentina Programa #YoProgramo", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("84c93c07-d513-444b-aae4-2a9610fca86a"), null, "Currently at 3rd year with an average of 9/10.", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10.", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("d00d4c4e-de55-4db6-af22-2c8afc99c3af"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REST API, Middlewares, C#, .NET 6, POO, Entity Framework, Sql Server.", true, "Platzi", false, "REST API, Middlewares, C#, .NET 6, POO, Entity Framework, Sql Server.", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET API's", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("e708e8af-bc5d-4e22-8857-c897a94e021c"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#, .NET 6, POO, Entity Framework, Fluent API, Sql Server.", true, "Platzi", false, "C#, .NET 6, POO, Entity Framework, Fluent API, Sql Server.", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entity Framework", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("e9e8f823-9741-48f3-9360-cf3d1adb2956"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We learned: C#, OOP, UML, .NET Framework, Entity Framework, Sql Server.\nFinal Project: https://github.com/tiagoramirez/tpFinalCursoDotNetNeorisUTN", true, "Universidad Tecnologica Nacional FRBA", false, "Aprendimos: C#, POO, UML, .NET Framework, Entity Framework, Sql Server.\nProyecto final: https://github.com/tiagoramirez/tpFinalCursoDotNetNeorisUTN", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desarrollador .NET", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("97826f17-a722-4059-8596-027ee258d3ac"), "Accusys", null, "Maintenance of an Bank Cash Control system.\nManagement and optimization of queries, tables, stored procedures and views in MS SQL Server databases.\nTechnologies: WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS.", true, true, "Mantenimiento de un sistema para el Control del Efectivo Bancario.\nManejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server.\nTecnologías: WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS.", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("efdf00a2-e245-4ef2-8aaf-7aa503b8bf74"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://tiagoramirez-portfolio.netlify.app/tiagoramirez", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("b0d11911-26a0-4eb8-a298-68fcfba57f3a"), 3, "https://www.linkedin.com/in/tiagoramirezmar/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("dcb2877b-ba91-48a1-a97e-e8ffbb3ecca9"), 1, "https://www.github.com/tiagoramirez/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00dc2e10-effc-49e1-ba7d-b77c2be5981f"), 95, new Guid("ecf0f4a4-4db2-4cb5-88e3-28bcb7b5e22b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("013479fa-ed0a-4a47-8be2-75cdc468e6c2"), 100, new Guid("13dad750-ff04-41c6-88dc-7c63a8d92253"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("0139d285-023d-4116-bf51-ad03875ed501"), 95, new Guid("be8a0b50-4968-4321-af62-e38a78a1fc05"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("01ef8666-8bf7-49eb-9d7b-60f1c0788d57"), 100, new Guid("61243c4e-e7ef-4d20-8af8-700f46806840"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("0931ef69-1fe6-44bd-9a4b-812439517b58"), 100, new Guid("82747309-dd6d-4709-ab40-03a492eeb39c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("0a855738-98dd-404c-9259-8bb4d1054bde"), 90, new Guid("cb322319-2b06-43a2-bd21-e42a7b8c878b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("0dfe7e24-29c4-4e7c-94e7-bcd254f767c7"), 90, new Guid("59a1fd14-d980-400e-98e9-a1193f10f59f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("22f2ce82-45e4-4ea9-a060-cdfa450b4a54"), 70, new Guid("4d57dfff-a8ec-44d0-87d1-0715811a79e4"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("255b9400-14ce-43e5-b7c7-60e15a279429"), 90, new Guid("f3c82a6e-3625-4f8d-ae73-bad613988c4d"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("2964e16f-494e-45a9-a69a-8dfb777b9862"), 90, new Guid("86278975-69b0-4f93-85ec-2dcfc580a35f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("30a14186-be3c-469f-a234-44530416acf8"), 100, new Guid("01965419-f26a-41a5-94ba-d996d4f1a15f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("31a9d050-acf3-4e6e-9434-47ae1eb30b7d"), 70, new Guid("634694e0-512b-454d-9981-79930220821f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3439ae8e-4bdb-43a1-9f0e-e7ad7d984075"), 95, new Guid("7cee6703-8006-447f-a5f9-2739153eaec9"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("37e87c39-a0f7-4c90-a115-d3c37a64c1fe"), 100, new Guid("8359daf2-cc0d-4e03-9baa-72e326f51488"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3c0873aa-c02b-4a9d-ac46-e59de57785c4"), 80, new Guid("82925956-b209-4a21-ac0f-994c16c851da"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("40e02268-99a1-44d5-b509-506caaf84791"), 90, new Guid("c99311bf-a884-45f2-bc3f-f8a7ee094833"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4545cba4-da34-402b-a42d-8d7611b3f9f4"), 90, new Guid("897ea43f-bb82-4520-8092-87078f4d9668"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("56f6953a-c8b7-487b-a081-69fc60ea1da8"), 90, new Guid("fcff6f01-948b-4bc0-a282-5cdd88e4f064"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("5a23ba60-1059-46b9-8afe-d336252e91e6"), 90, new Guid("52a44d73-4f89-4c1c-a75d-14d0628ab909"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6016cb7d-1fe7-4e49-a067-f0f80669737f"), 90, new Guid("6d0b4661-d4ef-4c6f-841a-cab0ef99865f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6bffa3a9-2af8-4424-9d67-3466832687ef"), 100, new Guid("b92ee2a1-1b20-494d-8226-774f193026a6"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("700ea12c-02c5-41dd-aea4-60d5b8ca222c"), 90, new Guid("51773eef-bce4-49d5-9d81-a2d2c37d443b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8128da83-47a4-460c-9067-d425789b73c6"), 80, new Guid("eec9860d-4f68-4ecf-8283-944211113d0d"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("85139a16-a5c0-4d3d-8c07-f5b7d2879ca5"), 80, new Guid("591db0f6-11a5-4e78-bdd2-f3b12453e0de"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("997bcc46-3b28-4372-a17d-3bd6d2885a75"), 95, new Guid("ecb0514d-3cd4-4c8a-8b72-875cadda5e92"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("acfd4485-1038-4d99-89e9-74619a68c480"), 70, new Guid("cee20429-7bb4-4fcf-ba73-5b9d94d6ae72"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("ad42cfb4-6c45-4cb9-ada1-4f5858a1d31d"), 80, new Guid("ec5ff3db-1eb7-4de7-a434-9d3c1cee27b6"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c44313b3-c68f-465c-82c4-4d869abe9723"), 100, new Guid("7ea656a8-14a6-4237-8277-995aec5c1955"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("d0d794dc-e71b-4303-ab21-30e9d2537bca"), 95, new Guid("2a5c60aa-11e9-47f4-89a6-614d4e60bcbb"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("d3a09362-a32a-4fd0-961f-413236541ad6"), 85, new Guid("b1dc9295-e48d-4def-aece-a9fec1e835f3"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("da43e80d-2972-4616-a451-258743eedbf0"), 75, new Guid("01bff10b-52a7-4b57-ad0f-0f133152a715"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("e6325170-74fd-4232-8328-368563adf011"), 100, new Guid("ea945c78-99c8-483d-8e3c-1207d5e2b92e"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("f17b1313-f5f3-454b-94b3-79ce2f522393"), 90, new Guid("af9ab891-c034-47c0-a626-13d2ed509d03"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("fdcaa748-4686-4d7a-9fbf-a210f85d9b86"), 80, new Guid("7a116620-167f-492a-bfcc-64cf7508ee88"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.CreateIndex(
                name: "IX_Education_UserId",
                table: "Education",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_UserId",
                table: "Experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserId",
                table: "Project",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_UserId",
                table: "SocialMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Skill_SkillId",
                table: "User_Skill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Skill_UserId",
                table: "User_Skill",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "User_Skill");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
