--Works

WITH RegularSeasonStats AS (
    SELECT T.Name AS TeamName,
        COUNT(CASE WHEN PS.Points > OPP.Points THEN 1 END) * 1.0 / COUNT(*) AS RegularWinPercentage,
        COUNT(CASE WHEN PS.Points < OPP.Points THEN 1 END) * 1.0 / COUNT(*) AS RegularLossPercentage,
        AVG(PS.Yards) AS RegularYardsPerGame,
        AVG(PS.Points) AS RegularPointsPerGame
    FROM Football.Match M
    INNER JOIN Football.Team T ON M.HomeTeamId = T.TeamId OR M.AwayTeamId = T.TeamId
    INNER JOIN Football.PlayerMatchStats PS ON PS.MatchId = M.MatchId AND PS.TeamId = T.TeamId
    LEFT JOIN Football.PlayerMatchStats OPP ON OPP.MatchId = M.MatchId AND OPP.TeamId != T.TeamId
    INNER JOIN Football.Season S ON M.Date BETWEEN S.StartDate AND S.PlayoffsDate
    WHERE M.Date < S.PlayoffsDate
    GROUP BY T.Name
),
PlayoffStats AS (
    SELECT T.Name AS TeamName,
        COUNT(CASE WHEN PS.Points > OPP.Points THEN 1 END) * 1.0 / COUNT(*) AS PlayoffWinPercentage,
        COUNT(CASE WHEN PS.Points < OPP.Points THEN 1 END) * 1.0 / COUNT(*) AS PlayoffLossPercentage,
	    AVG(PS.Yards) AS PlayoffYardsPerGame,
        AVG(PS.Points) AS PlayoffPointsPerGame
    FROM Football.Match M
    INNER JOIN Football.Team T ON M.HomeTeamId = T.TeamId OR M.AwayTeamId = T.TeamId
    INNER JOIN Football.PlayerMatchStats PS ON PS.MatchId = M.MatchId AND PS.TeamId = T.TeamId
    LEFT JOIN Football.PlayerMatchStats OPP ON OPP.MatchId = M.MatchId AND OPP.TeamId != T.TeamId
    INNER JOIN Football.Season S ON M.Date BETWEEN S.PlayoffsDate AND S.EndDate
    WHERE M.Date >= S.PlayoffsDate
    GROUP BY T.Name
)
SELECT RS.TeamName, RS.RegularWinPercentage, PS.PlayoffWinPercentage, RS.RegularLossPercentage, PS.PlayoffLossPercentage,
	   RS.RegularYardsPerGame, PS.PlayoffYardsPerGame, RS.RegularPointsPerGame, PS.PlayoffPointsPerGame
FROM RegularSeasonStats RS
	LEFT JOIN PlayoffStats PS ON RS.TeamName = PS.TeamName;
