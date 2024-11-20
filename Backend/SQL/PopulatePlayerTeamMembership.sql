--ValueTable(PlayerId,TeamName,StartDate,EndDate) created by c# code
Insert
into Football.PlayerTeamHistory (PlayerId, TeamId, StartDate, EndDate, PositionId, PlayerNumber)
Select ValueTable.PlayerId, t.TeamId, ValueTable.StartDate, ValueTable.EndDate, 1, 1
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName
where exists(Select *
             from Football.Player p
             where p.PlayerId = ValueTable.PlayerId)


