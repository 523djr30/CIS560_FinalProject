--works

--Declare @TeamName1 NVarChar(32) = N'Dolphins';
--Declare @TeamName2 NVarChar(32) = N'Bills';

WITH MatchStats AS (
    SELECT distinct m.MatchId, m.Date AS MatchDate, s.Name AS StadiumName, ht.Name AS HomeTeamName, ht.TeamId AS HomeTeamId,
        at.Name AS AwayTeamName, at.TeamId AS AwayTeamId, pms_home.Points AS HomeTeamPoints, pms_away.Points AS AwayTeamPoints
    FROM Football.Match m
    INNER JOIN Football.Stadium s ON m.StadiumId = s.StadiumId
    INNER JOIN Football.Team ht ON m.HomeTeamId = ht.TeamId
    INNER JOIN Football.Team at ON m.AwayTeamId = at.TeamId
    LEFT JOIN Football.PlayerMatchStats pms_home ON m.MatchId = pms_home.MatchId AND pms_home.TeamId = ht.TeamId
    LEFT JOIN Football.PlayerMatchStats pms_away ON m.MatchId = pms_away.MatchId AND pms_away.TeamId = at.TeamId
    WHERE (ht.Name = @TeamName1 AND at.Name = @TeamName2) OR (ht.Name = @TeamName2 AND at.Name = @TeamName1)
)

SELECT StadiumName, MatchDate AS Date, HomeTeamName, HomeTeamPoints, AwayTeamName, AwayTeamPoints,
    CASE
        WHEN HomeTeamPoints > AwayTeamPoints THEN HomeTeamName
        WHEN AwayTeamPoints > HomeTeamPoints THEN AwayTeamName
        ELSE 'Draw' -- if theres a Draw
    END AS WinningTeamName
FROM MatchStats
ORDER BY MatchDate;
