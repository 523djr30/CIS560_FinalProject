--ValueTable(PlayerId,TeamName,Date,Yards,Points) created by c# code
Insert
into Football.PlayerMatchStats (PlayerTeamHistoryId, MatchId, TeamId, Yards, Points)
Select pth.PlayerTeamHistoryId, m.MatchId, Max(t.TeamId), Max(ValueTable.Yards), Max(ValueTable.Points)
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName
         inner join Football.Match m
                    on m.Date = ValueTable.Date and (m.HomeTeamId = t.TeamId or m.AwayTeamId = t.TeamId)
         inner join Football.PlayerTeamHistory pth on
    (pth.TeamId = t.TeamId) and
    (pth.StartDate <= ValueTable.Date) and ((pth.EndDate >= ValueTable.Date) or (pth.EndDate is null))
where not exists(Select *
                 from Football.PlayerMatchStats pms
                 where pms.MatchId = m.MatchId
                   and pms.PlayerTeamHistoryId = pth.PlayerTeamHistoryId)
group by pth.PlayerTeamHistoryId, m.MatchId --//the data is messed up and has multiple entries for same player in same game with different score in a few instances
    


