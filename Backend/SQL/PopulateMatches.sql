--ValueTable(Date,HomeTeamName,AwayTeamName) created by c# code
Insert
into Football.Match (Date, HomeTeamId, AwayTeamId, StadiumId)
Select ValueTable.Date, ht.TeamId, at.TeamId, s.StadiumId
from ValueTable
         inner join Football.Team ht on ht.Name = ValueTable.HomeTeamName
         inner join Football.Team at on at.Name = ValueTable.AwayTeamName
         inner join Football.Stadium s on s.TeamId = ht.TeamId


