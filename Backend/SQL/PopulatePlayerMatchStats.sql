--ValueTable(PlayerId,TeamName,Date,Yards,Points) created by c# code
Insert
into Football.PlayerMatchStats (PlayerTeamHistoryId, MatchId, TeamId, Yards, Points)
Select pth.PlayerTeamHistoryId, m.MatchId, t.TeamId, ValueTable.Yards, ValueTable.Points
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName
         inner join Football.Match m
                    on m.Date = ValueTable.Date
                        and (m.HomeTeamId = t.TeamId
                            or m.AwayTeamId = t.TeamId)
         inner join Football.PlayerTeamHistory pth on
    (pth.TeamId = t.TeamId) --This check on insertion ensures that the multiple paths agree
    --That is, the path to Team from the PTH table agrees with the ValueTable source,
    --And the paths thru Match m also agree
        and (pth.PlayerID = ValueTable.PlayerId) and
    (pth.StartDate <= ValueTable.Date) and ((pth.EndDate >= ValueTable.Date) or (pth.EndDate is null))