--works

--Declare @FirstName NVarChar(32) = N'Giovani';
--Declare @LastName NVarChar(32) = N'Bernard';

WITH RecentTeamInfo AS (
    SELECT p.PlayerId,t.Name AS MostRecentTeamName,pth.PlayerNumber AS MostRecentPlayerNumber,
        ROW_NUMBER() OVER (
            PARTITION BY p.PlayerId 
            ORDER BY pth.EndDate DESC, pth.StartDate DESC
        ) AS RowNum
    FROM Football.Player p
    INNER JOIN Football.PlayerTeamHistory pth ON p.PlayerId = pth.PlayerId
    INNER JOIN Football.Team t ON pth.TeamId = t.TeamId
)
SELECT  p.PlayerId Id, rti.MostRecentTeamName Team, rti.MostRecentPlayerNumber Number,
    SUM(pms.Yards) AS TotalYards,
    SUM(pms.Points) AS TotalPoints
FROM Football.Player p
INNER JOIN RecentTeamInfo rti ON p.PlayerId = rti.PlayerId AND rti.RowNum = 1
INNER JOIN Football.PlayerTeamHistory pth ON p.PlayerId = pth.PlayerId
INNER JOIN Football.PlayerMatchStats pms ON pth.PlayerTeamHistoryId = pms.PlayerTeamHistoryId
WHERE p.FirstName = @FirstName AND p.LastName = @LastName
GROUP BY p.PlayerId, rti.MostRecentTeamName, rti.MostRecentPlayerNumber;
