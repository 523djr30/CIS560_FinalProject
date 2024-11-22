﻿--ValueTable(PlayerId,TeamName,Date,Yards,Points) created by c# code
Insert
into Football.PlayerMatchStats (PlayerTeamHistoryId, MatchId, TeamId, Yards, Points)
Select pth.PlayerTeamHistoryId, m.MatchId, t.TeamId, ValueTable.Yards, ValueTable.Points
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName
         inner join Football.Match m
                    on m.Date = ValueTable.Date and (m.HomeTeamId = t.TeamId or m.AwayTeamId = t.TeamId)
         inner join Football.PlayerTeamHistory pth on
    (pth.TeamId = t.TeamId) and (pth.PlayerID=ValueTable.PlayerId) and
    (pth.StartDate <= ValueTable.Date) and ((pth.EndDate >= ValueTable.Date) or (pth.EndDate is null))