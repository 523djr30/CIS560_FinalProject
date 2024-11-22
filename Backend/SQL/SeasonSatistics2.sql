--Declare @SeasonId int = 2001;
--Declare @TeamName NVarChar(32) = N'Bills';

WITH TeamSeasonStats AS (
    SELECT T.Name AS TeamName, S.SeasonId,
        COUNT(CASE WHEN (M.HomeTeamId = T.TeamId AND 
						(SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.HomeTeamId) > 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.AwayTeamId)) 
                     OR 
                       (M.AwayTeamId = T.TeamId AND 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.AwayTeamId) > 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.HomeTeamId)) 
                  THEN 1 
             END) AS Wins,
        COUNT(CASE WHEN (M.HomeTeamId = T.TeamId AND 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.HomeTeamId) < 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.AwayTeamId)) 
                     OR 
                       (M.AwayTeamId = T.TeamId AND 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.AwayTeamId) < 
                        (SELECT SUM(PS.Points) 
                         FROM Football.PlayerMatchStats PS 
                         WHERE PS.MatchId = M.MatchId AND PS.TeamId = M.HomeTeamId)) 
                  THEN 1 
             END) AS Losses
    FROM Football.Match M
    INNER JOIN Football.Team T ON M.HomeTeamId = T.TeamId OR M.AwayTeamId = T.TeamId
    INNER JOIN Football.Season S ON M.Date BETWEEN S.StartDate AND S.EndDate
    WHERE S.SeasonId = @SeasonId  -- Parameter: Season
          AND T.Name = @TeamName  -- Parameter: Team Name
    GROUP BY T.Name, S.SeasonId
)
SELECT TeamName, SeasonId AS Season, Wins, Losses
FROM TeamSeasonStats;
