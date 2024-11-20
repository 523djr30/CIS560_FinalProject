With ValueTable as (Select *
           from (Values (N'Buffalo Bills', N'Highmark Stadium'),
                        (N'Miami Dolphins', N'Hard Rock Stadium'),
                        (N'New England Patriots', N'Gillette Stadium'),
                        (N'New York Jets', N'MetLife Stadium'),
                        (N'Baltimore Ravens', N'M&T Bank Stadium'),
                        (N'Cincinnati Bengals', N'Paycor Stadium'),
                        (N'Cleveland Browns', N'Cleveland Browns Stadium'),
                        (N'Pittsburgh Steelers', N'Acrisure Stadium'),
                        (N'Houston Texans', N'NRG Stadium'),
                        (N'Indianapolis Colts', N'Lucas Oil Stadium'),
                        (N'Jacksonville Jaguars', N'TIAA Bank Field'),
                        (N'Tennessee Titans', N'Nissan Stadium'),
                        (N'Denver Broncos', N'Empower Field at Mile High'),
                        (N'Kansas City Chiefs', N'GEHA Field at Arrowhead Stadium'),
                        (N'Las Vegas Raiders', N'Allegiant Stadium'),
                        (N'Los Angeles Chargers', N'SoFi Stadium'),
                        (N'Dallas Cowboys', N'AT&T Stadium'),
                        (N'New York Giants', N'MetLife Stadium'),
                        (N'Philadelphia Eagles', N'Lincoln Financial Field'),
                        (N'Washington Commanders', N'FedExField'),
                        (N'Chicago Bears', N'Soldier Field'),
                        (N'Detroit Lions', N'Ford Field'),
                        (N'Green Bay Packers', N'Lambeau Field'),
                        (N'Minnesota Vikings', N'U.S. Bank Stadium'),
                        (N'Atlanta Falcons', N'Mercedes-Benz Stadium'),
                        (N'Carolina Panthers', N'Bank of America Stadium'),
                        (N'New Orleans Saints', N'Caesars Superdome'),
                        (N'Tampa Bay Buccaneers', N'Raymond James Stadium'),
                        (N'Arizona Cardinals', N'State Farm Stadium'),
                        (N'Los Angeles Rams', N'SoFi Stadium'),
                        (N'San Francisco 49ers', N'Levis Stadium'),
                        (N'Seattle Seahawks', N'Lumen Field')) as v (TeamName, StadiumName))
Insert
into Football.Stadium (TeamId, State, City, Name)
Select t.TeamId, t.State, t.City, ValueTable.StadiumName
from ValueTable
         inner join Football.Team t on t.Name = ValueTable.TeamName


