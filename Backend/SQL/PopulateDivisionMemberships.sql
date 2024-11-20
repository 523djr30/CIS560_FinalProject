With ValueTable as (Select *
                    from (Values (N'AFC NORTH', 'Steelers'),
                                 (N'AFC NORTH', 'Ravens'),
                                 (N'AFC NORTH', 'Bengals'),
                                 (N'AFC NORTH', 'Browns'),
                                 (N'AFC EAST', 'Bills'),
                                 (N'AFC EAST', 'Dolphins'),
                                 (N'AFC EAST', 'Jets'),
                                 (N'AFC EAST', 'Patriots'),
                                 (N'AFC SOUTH', 'Texans'),
                                 (N'AFC SOUTH', 'Colts'),
                                 (N'AFC SOUTH', 'Titans'),
                                 (N'AFC SOUTH', 'Jaguars'),
                                 (N'AFC WEST', 'Chiefs'),
                                 (N'AFC WEST', 'Chargers'),
                                 (N'AFC WEST', 'Broncos'),
                                 (N'AFC WEST', 'Raiders'),
                                 (N'NFC EAST', 'Eagles'),
                                 (N'NFC EAST', 'Commanders'),
                                 (N'NFC EAST', 'Cowboys'),
                                 (N'NFC EAST', 'Giants'),
                                 (N'NFC NORTH', 'Lions'),
                                 (N'NFC NORTH', 'Vikings'),
                                 (N'NFC NORTH', 'Packers'),
                                 (N'NFC NORTH', 'Bears'),
                                 (N'NFC SOUTH', 'Falcons'),
                                 (N'NFC SOUTH', 'Buccaneers'),
                                 (N'NFC SOUTH', 'Saints'),
                                 (N'NFC SOUTH', 'Panthers'),
                                 (N'NFC WEST', 'Cardinals'),
                                 (N'NFC WEST', 'Rams'),
                                 (N'NFC WEST', 'Seahawks'),
                                 (N'NFC WEST', '49ers')) as v (DivisionName,TeamName))
Insert
into Football.DivisionMembership (DivisionId,TeamId,StartDate)
Select d.DivisionId, t.TeamId,'1000-01-01'
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName
         inner join Football.Division d on d.Name = ValueTable.DivisionName
