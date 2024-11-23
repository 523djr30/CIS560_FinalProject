-- Returns a table that ranks the cumulative records of every team in the division across the NFL.

DECLARE @MatchStatsTbl TABLE ( HomeTeamId INT, HomeTeamName NVARCHAR(32), HomeTeamPoints INT, AwayTeamId INT, AwayTeamName NVARCHAR(32), AwayTeamPoints INT, MatchDate DATETIMEOFFSET, WinningTeamId INT);

WITH MatchStats AS (
    SELECT distinct m.MatchId, m.Date AS MatchDate, s.Name AS StadiumName, ht.Name AS HomeTeamName, ht.TeamId AS HomeTeamId,
        at.Name AS AwayTeamName, at.TeamId AS AwayTeamId, pms_home.Points AS HomeTeamPoints, pms_away.Points AS AwayTeamPoints
    FROM Football.Match m
    INNER JOIN Football.Stadium s ON m.StadiumId = s.StadiumId
    INNER JOIN Football.Team ht ON m.HomeTeamId = ht.TeamId
    INNER JOIN Football.Team at ON m.AwayTeamId = at.TeamId
    LEFT JOIN Football.PlayerMatchStats pms_home ON m.MatchId = pms_home.MatchId AND pms_home.TeamId = ht.TeamId
    LEFT JOIN Football.PlayerMatchStats pms_away ON m.MatchId = pms_away.MatchId AND pms_away.TeamId = at.TeamId
	
)
INSERT INTO @MatchStatsTbl
SELECT HomeTeamId, HomeTeamName, HomeTeamPoints, AwayTeamId, AwayTeamName, AwayTeamPoints, MatchDate AS Date,
    CASE
        WHEN HomeTeamPoints > AwayTeamPoints THEN HomeTeamId
        WHEN AwayTeamPoints > HomeTeamPoints THEN AwayTeamId
        ELSE NULL -- if theres a Draw
    END AS WinningTeamName
FROM MatchStats
ORDER BY MatchDate;

DECLARE @Winners TABLE (TeamId NVARCHAR(32), TeamName NVARCHAR(32), Wins INT, Losses INT);
INSERT INTO @Winners
Select T.TeamId, T.[Name], (COUNT(*) - COUNT(CASE WHEN T.TeamId <> M.WinningTeamId THEN 1 END)) AS Wins, COUNT(CASE WHEN T.TeamId <> M.WinningTeamId THEN 1 END) AS Losses
From Football.Team T
INNER JOIN @MatchStatsTbl M On T.TeamId = M.HomeTeamId OR T.TeamId = M.AwayTeamId
INNER JOIN Football.Season S ON M.[MatchDate] BETWEEN S.StartDate AND S.EndDate
Group By T.TeamId, T.[Name]
Order By T.TeamId

Select D.[Name] AS DivisionName, W.TeamId, W.TeamName, RANK() OVER(PARTITION BY D.[Name] ORDER BY Wins DESC) AS [TeamRank], Wins, Losses
From Football.Division D
INNER JOIN Football.DivisionMembership DM ON DM.DivisionID = D.DivisionId
Inner Join @Winners W ON W.TeamId = DM.TeamID
Order By DivisionName, TeamRank