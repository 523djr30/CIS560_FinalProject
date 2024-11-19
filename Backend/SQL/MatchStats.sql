WITH MatchStats AS (
    SELECT m.MatchId, m.Date AS MatchDate, s.Name AS StadiumName, ht.Name AS HomeTeamName, ht.TeamId AS HomeTeamId,
        at.Name AS AwayTeamName, at.TeamId AS AwayTeamId, pms_home.Points AS HomeTeamPoints, pms_away.Points AS AwayTeamPoints
    FROM Match m
    INNER JOIN Stadium s ON m.StadiumId = s.StadiumId
    INNER JOIN Teams ht ON m.HomeTeamId = ht.TeamId
    INNER JOIN Teams at ON m.AwayTeamId = at.TeamId
    LEFT JOIN PlayerMatchStats pms_home ON m.MatchId = pms_home.MatchId AND pms_home.TeamId = ht.TeamId
    LEFT JOIN PlayerMatchStats pms_away ON m.MatchId = pms_away.MatchId AND pms_away.TeamId = at.TeamId
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
