﻿// <auto-generated />
using Fotball_App.DataApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fotball_App.DataApi.Migrations
{
    [DbContext(typeof(FotballContext))]
    partial class FotballContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fotball_App.DataApi.Models.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Founded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeagueLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeagueName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeagueId");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            LeagueId = 1,
                            About = "Top league in england",
                            Founded = "20 February 1992",
                            LeagueLogo = "England.png",
                            LeagueName = "Premier League",
                            Nationality = "England"
                        },
                        new
                        {
                            LeagueId = 2,
                            About = "Top league in Spain",
                            Founded = "15 June 1929",
                            LeagueLogo = "Spain.png",
                            LeagueName = "La Liga",
                            Nationality = "Spain"
                        },
                        new
                        {
                            LeagueId = 3,
                            About = "Top league in France",
                            Founded = "11 September 1932",
                            LeagueLogo = "France.png",
                            LeagueName = "Ligue 1",
                            Nationality = "France"
                        },
                        new
                        {
                            LeagueId = 4,
                            About = "Top league in Italy",
                            Founded = "13 August 1929",
                            LeagueLogo = "Italia.png",
                            LeagueName = "Serie A",
                            Nationality = "Italia"
                        },
                        new
                        {
                            LeagueId = 5,
                            About = "Top league in Germany",
                            Founded = "28 July 1962",
                            LeagueLogo = "Germany.png",
                            LeagueName = "Bundesliga",
                            Nationality = "Germany"
                        });
                });

            modelBuilder.Entity("Fotball_App.DataApi.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("National")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            About = "Player in Manchester United",
                            Age = 37,
                            Height = 189,
                            National = "Portugal",
                            PlayerName = "Cristiano Ronaldo",
                            Position = "Forward",
                            ProfileImage = "Ronaldo.jpg"
                        },
                        new
                        {
                            PlayerId = 2,
                            About = "Player in Real Madrid",
                            Age = 34,
                            Height = 185,
                            National = "France",
                            PlayerName = "Karim Benzema",
                            Position = "Forward",
                            ProfileImage = "Karim.jpg"
                        },
                        new
                        {
                            PlayerId = 3,
                            About = "Player in Dortmund",
                            Age = 32,
                            Height = 180,
                            National = "Germany",
                            PlayerName = "Marco Reus",
                            Position = "Midfielder",
                            ProfileImage = "Reus.jpg"
                        },
                        new
                        {
                            PlayerId = 4,
                            About = "Player in Juventus",
                            Age = 31,
                            Height = 177,
                            National = "Brazil",
                            PlayerName = "Alex Sandro",
                            Position = "Defender",
                            ProfileImage = "Alex.jpg"
                        },
                        new
                        {
                            PlayerId = 5,
                            About = "Player in PSG",
                            Age = 34,
                            Height = 169,
                            National = "Argentina",
                            PlayerName = "Lionel Messi",
                            Position = "Forward",
                            ProfileImage = "Messi.jpg"
                        });
                });

            modelBuilder.Entity("Fotball_App.DataApi.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Country = "England",
                            Manager = "Erik Ten Hag",
                            TeamDescription = "Manchester United Football Club is a professional football club, that competes in the Premier League, the top flight of English football. \n\n Manchester United is one of the most successful clubs in English football, having won a record 20 League titles, 12 FA Cups, five League Cups and a record 21 FA Community Shields.They have won the European Cup/ UEFA Champions League three times, and the UEFA Europa League. \n\n Alex Ferguson is the club's longest-serving and most successful manager, winning 38 trophies.",
                            TeamLogo = "ManUtd.png",
                            TeamName = "Manchester United"
                        },
                        new
                        {
                            TeamId = 2,
                            Country = "Spain",
                            Manager = "Carlo Ancelotti",
                            TeamDescription = "Real Madrid Club de Fútbol, commonly referred to as Real Madrid or simply Real, is a Spanish professional football club based in Madrid. Founded on 6 March 1902 as Madrid Football Club. The team has played its home matches in the 81,044-capacity Santiago Bernabéu Stadium in downtown Madrid since 1947. \n\n In domestic football, the club has won 68 trophies; a record 35 La Liga titles, 19 Copa del Rey, 12 Supercopa de España, a Copa Eva Duarte, and a Copa de la Liga.In European football, Real Madrid have won a record 19 trophies; a record 13 European Cup/ UEFA Champions League titles, two UEFA Cups and four UEFA Super Cup.",
                            TeamLogo = "RealMadrid.png",
                            TeamName = "Real Madrid"
                        },
                        new
                        {
                            TeamId = 3,
                            Country = "Germany",
                            Manager = "Edin Terzic",
                            TeamDescription = "Ballspielverein Borussia 09 e. V. Dortmund, commonly known as Borussia Dortmund, BVB  or simply Dortmund, is a German professional sports club based in Dortmund, North Rhine-Westphalia. They play in the Bundesliga, the top tier of the German football league system. \n\n The club have won eight league championships, five DFB-Pokals, one UEFA Champions League, one Intercontinental Cup, and one UEFA Cup Winners' Cup.",
                            TeamLogo = "Dortmund.png",
                            TeamName = "Borrussia Dortmund"
                        },
                        new
                        {
                            TeamId = 4,
                            Country = "Italy",
                            Manager = "Massimiliano Allegri",
                            TeamDescription = "Juventus Football Club, commonly known as Juventus, or simply Juve is a professional football club based in Turin, Piedmont, Italy, that competes in the Serie A, the top tier of the Italian football league system. \n\n The club has won 36 official league titles, 14 Coppa Italia titles and nine Supercoppa Italiana titles, being the record holder for all these competitions; two Intercontinental Cups, two European Cups / UEFA Champions Leagues, one European Cup Winners' Cup, a joint national record of three UEFA Cups, two UEFA Super Cups and a joint national record of one UEFA Intertoto Cup.",
                            TeamLogo = "Juventus.png",
                            TeamName = "Juventus"
                        },
                        new
                        {
                            TeamId = 5,
                            Country = "France",
                            Manager = "Mauricio Pochettino",
                            TeamDescription = "Paris Saint-Germain Football Club commonly referred to as Paris Saint-Germain, Paris, Paris SG or simply PSG is a professional football club based in Paris, France. They compete in Ligue 1, the top division of French football. As France's most successful club, they have won over 40 official honours, including ten league titles and one major European trophy. Their home ground is the Parc des Princes.\n\n PSG have also become a regular feature in the UEFA Champions League, reaching their first final in 2020.PSG also won the league this year 21 / 22. ",
                            TeamLogo = "Psg.png",
                            TeamName = "Paris Saint Germain"
                        });
                });

            modelBuilder.Entity("PlayersInTeams", b =>
                {
                    b.Property<int>("TeamsTeamId")
                        .HasColumnType("int");

                    b.Property<int>("PlayersPlayerId")
                        .HasColumnType("int");

                    b.HasKey("TeamsTeamId", "PlayersPlayerId");

                    b.HasIndex("PlayersPlayerId");

                    b.ToTable("PlayersInTeams");

                    b.HasData(
                        new
                        {
                            TeamsTeamId = 1,
                            PlayersPlayerId = 1
                        },
                        new
                        {
                            TeamsTeamId = 2,
                            PlayersPlayerId = 2
                        },
                        new
                        {
                            TeamsTeamId = 3,
                            PlayersPlayerId = 3
                        },
                        new
                        {
                            TeamsTeamId = 4,
                            PlayersPlayerId = 4
                        },
                        new
                        {
                            TeamsTeamId = 5,
                            PlayersPlayerId = 5
                        });
                });

            modelBuilder.Entity("TeamsInLeague", b =>
                {
                    b.Property<int>("LeaguesLeagueId")
                        .HasColumnType("int");

                    b.Property<int>("TeamTeamsId")
                        .HasColumnType("int");

                    b.HasKey("LeaguesLeagueId", "TeamTeamsId");

                    b.HasIndex("TeamTeamsId");

                    b.ToTable("TeamsInLeague");

                    b.HasData(
                        new
                        {
                            LeaguesLeagueId = 1,
                            TeamTeamsId = 1
                        },
                        new
                        {
                            LeaguesLeagueId = 2,
                            TeamTeamsId = 2
                        },
                        new
                        {
                            LeaguesLeagueId = 3,
                            TeamTeamsId = 5
                        },
                        new
                        {
                            LeaguesLeagueId = 4,
                            TeamTeamsId = 4
                        },
                        new
                        {
                            LeaguesLeagueId = 5,
                            TeamTeamsId = 3
                        });
                });

            modelBuilder.Entity("PlayersInTeams", b =>
                {
                    b.HasOne("Fotball_App.DataApi.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fotball_App.DataApi.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamsInLeague", b =>
                {
                    b.HasOne("Fotball_App.DataApi.Models.League", null)
                        .WithMany()
                        .HasForeignKey("LeaguesLeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fotball_App.DataApi.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamTeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
