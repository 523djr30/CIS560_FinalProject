WITH RecentTeamInfo AS (
    SELECT p.PlayerId,t.Name AS MostRecentTeamName,pth.PlayerNumber AS MostRecentPlayerNumber,
        ROW_NUMBER() OVER (
            PARTITION BY p.PlayerId 
            ORDER BY pth.EndDate DESC, pth.StartDate DESC
        ) AS RowNum
    FROM Player p
    INNER JOIN PlayerTeamHistory pth ON p.PlayerId = pth.PlayerId
    INNER JOIN Team t ON pth.TeamId = t.TeamId
)
SELECT  p.PlayerId, rti.MostRecentTeamName, rti.MostRecentPlayerNumber,
    SUM(pms.Yards) AS TotalYards,
    SUM(pms.Points) AS TotalPoints
FROM Player p
INNER JOIN RecentTeamInfo rti ON p.PlayerId = rti.PlayerId AND rti.RowNum = 1
INNER JOIN PlayerTeamHistory pth ON p.PlayerId = pth.PlayerId
INNER JOIN PlayerMatchStats pms ON pth.PlayerTeamHistoryId = pms.PlayerTeamHistoryId
WHERE p.FirstName = @FirstName AND p.LastName = @LastName
GROUP BY p.PlayerId, rti.MostRecentTeamName, rti.MostRecentPlayerNumber;