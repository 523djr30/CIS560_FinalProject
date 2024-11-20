With ValueTable as (Select *
           from (Values (N'Bills', N'Highmark Stadium'),
                        (N'Dolphins', N'Hard Rock Stadium'),
                        (N'Patriots', N'Gillette Stadium'),
                        (N'Jets', N'MetLife Stadium'),
                        (N'Ravens', N'M&T Bank Stadium'),
                        (N'Bengals', N'Paycor Stadium'),
                        (N'Browns', N'Cleveland Browns Stadium'),
                        (N'Steelers', N'Acrisure Stadium'),
                        (N'Texans', N'NRG Stadium'),
                        (N'Colts', N'Lucas Oil Stadium'),
                        (N'Jaguars', N'TIAA Bank Field'),
                        (N'Titans', N'Nissan Stadium'),
                        (N'Broncos', N'Empower Field at Mile High'),
                        (N'Chiefs', N'GEHA Field at Arrowhead Stadium'),
                        (N'Raiders', N'Allegiant Stadium'),
                        (N'Angeles Chargers', N'SoFi Stadium'),
                        (N'Cowboys', N'AT&T Stadium'),
                        (N'Giants', N'MetLife Stadium'),
                        (N'Eagles', N'Lincoln Financial Field'),
                        (N'Commanders', N'FedExField'),
                        (N'Bears', N'Soldier Field'),
                        (N'Lions', N'Ford Field'),
                        (N'Packers', N'Lambeau Field'),
                        (N'Vikings', N'U.S. Bank Stadium'),
                        (N'Falcons', N'Mercedes-Benz Stadium'),
                        (N'Panthers', N'Bank of America Stadium'),
                        (N'Orleans Saints', N'Caesars Superdome'),
                        (N'Bay Buccaneers', N'Raymond James Stadium'),
                        (N'Cardinals', N'State Farm Stadium'),
                        (N'Angeles Rams', N'SoFi Stadium'),
                        (N'Francisco 49ers', N'Levis Stadium'),
                        (N'Seahawks', N'Lumen Field')) as v (TeamName, StadiumName))
Insert
into Football.Stadium (TeamId, State, City, Name)
Select t.TeamId, t.State, t.City, ValueTable.StadiumName
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName


