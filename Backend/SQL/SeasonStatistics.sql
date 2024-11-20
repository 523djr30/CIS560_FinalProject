WITH TeamSeasonStats AS (
    SELECT T.Name AS TeamName,S.SeasonId,
        COUNT(CASE WHEN (M.HomeTeamId = T.TeamId AND HomePoints > AwayPoints) 
                     OR (M.AwayTeamId = T.TeamId AND AwayPoints > HomePoints) THEN 1 END) AS Wins,
        COUNT(CASE WHEN (M.HomeTeamId = T.TeamId AND HomePoints < AwayPoints) 
                     OR (M.AwayTeamId = T.TeamId AND AwayPoints < HomePoints) THEN 1 END) AS Losses,
        SUM(PS.Yards) AS TotalYards,
        AVG(PS.Yards) AS AverageYardsPerGame,
        SUM(PS.Points) AS TotalPoints,
        AVG(PS.Points) AS AveragePointsPerGame
    FROM Match M
    INNER JOIN Team T ON M.HomeTeamId = T.TeamId OR M.AwayTeamId = T.TeamId
    INNER JOIN PlayerMatchStats PS ON PS.MatchId = M.MatchId AND PS.TeamId = T.TeamId
    INNER JOIN Season S ON M.Date BETWEEN S.StartDate AND S.EndDate
    WHERE 
        S.SeasonId = {SeasonId}  -- Parameter: Season
        AND T.Name = '{TeamName}' -- Parameter: Team Name
    GROUP BY 
        T.Name, S.SeasonId
)
SELECT TeamName, SeasonId AS Season, Wins, Losses, TotalYards, AverageYardsPerGame, TotalPoints, AveragePointsPerGame
FROM TeamSeasonStats;