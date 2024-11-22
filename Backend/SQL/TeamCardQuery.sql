--Query to give all the information necessary for every team's teamcard in the GUI
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


With TeamWinsCTE AS(
Select T.TeamId, S.SeasonId, (COUNT(*) - COUNT(CASE WHEN T.TeamId <> M.WinningTeamId THEN 1 END)) AS Wins, COUNT(CASE WHEN T.TeamId <> M.WinningTeamId THEN 1 END) AS Losses
From Football.Team T
INNER JOIN @MatchStatsTbl M On T.TeamId = M.HomeTeamId OR T.TeamId = M.AwayTeamId
INNER JOIN Football.Season S ON M.[MatchDate] BETWEEN S.StartDate AND S.EndDate
--WHERE S.SeasonId = @SeasonId -- Param, SeasonId
Group By T.TeamId, S.SeasonId
)
Select T.[Name] AS TeamName, MAX(T.City) AS City, MAX(Stad.[Name]) AS StadiumName, MAX(D.[Name]) AS DivisionName, SUM(TW.Wins) AS Wins, SUM(TW.Losses) AS Losses
From Football.Team T
Left Join Football.Stadium Stad ON Stad.TeamID = T.TeamId
Left Join Football.DivisionMembership DM ON DM.TeamID = T.TeamId
Left Join Football.Division D ON D.DivisionId = DM.DivisionID
Left Join TeamWinsCTE TW ON TW.TeamId = T.TeamId
Group by T.TeamId, T.[Name]