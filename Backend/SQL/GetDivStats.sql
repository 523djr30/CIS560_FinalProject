With TeamDivisionMembers(TeamId, TeamName, DivisionName) AS
(
	Select T.TeamId, T.TeamName, D.DivisionName
	From Football.Division D
	Inner Join Football.DivisionMembership DM ON DM.DivisionId = D.DivisionId
	Inner Join Football.Team T ON T.TeamId = DM.TeamId
), 
TeamSeasonStats(TeamName, SeasonId, Wins, Losses) AS (
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
Select Div.DivisionName AS [Division], Div.TeamName AS [Name], Stat.Wins, Stat.Losses
From TeamDivisionMembers Div 
Inner Join TeamSeasonStats Stat On Stat.TeamId = Div.TeamId
Inner Join Football.Season S ON S.SeasonId = Stat.SeasonId
Where CHARINDEX(@DivisionCode,Div.DivisionName) > 0 AND S.SeasonId = @SeasonId