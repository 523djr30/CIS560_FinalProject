IF SCHEMA_ID(N'Football') IS NULL
    EXEC (N'CREATE SCHEMA Football;');
GO
/*Table Create Order
1:  Positions
    Team
    Division
    Player
    Season
2:  DivisionMembership
    PlayerTeamHistory
    Stadium
3:  Match
4:  PlayerMatchStats
*/

Drop Table IF EXISTS Football.PlayerMatchStats;

Drop Table IF EXISTS Football.Match;

Drop Table IF EXISTS Football.DivisionMembership;
Drop Table IF EXISTS Football.PlayerTeamHistory;
Drop Table IF EXISTS Football.Stadium;

Drop Table IF EXISTS Football.Positions;
Drop Table IF EXISTS Football.Team;
Drop Table IF EXISTS Football.Division;
Drop Table IF EXISTS Football.Player;
Drop Table IF EXISTS Football.Season;
GO

-- Stage 1: Standalone Tables
Create Table Football.Positions
(
    PositionId int          not null identity (1, 1) primary key,
    Name       NVarChar(32) not null unique,
    ShortName  NVarChar(4)  not null unique,
);

Create Table Football.Team
(
    TeamId int          not null identity (1, 1) primary key,
    Name   NVarChar(64) not null unique,
    State  NVarChar(32) not null,
    City  NVarChar(32) not null,
);

Create Table Football.Division
(
    DivisionId int          not null identity (1, 1) primary key,
    Name       NVarChar(64) not null unique,
);

Create Table Football.Player
(
    PlayerId  int          not null /*identity (1, 1)*/ primary key,
    FirstName NVarChar(64) not null,
    LastName  NVarChar(64) not null,
    Bio       NVarChar(512),
);


Create Table Football.Season
(
    SeasonId     int            not null identity (1, 1) primary key,
    StartDate    DateTimeOffset not null,
    PlayoffsDate DateTimeOffset,
    EndDate      DateTimeOffset not null,
);
Go

--Stage 2
Create Table Football.DivisionMembership
(
    DivisionMembershipId int            not null identity (1, 1) primary key,
    DivisionID           int            not null foreign key references Football.Division (DivisionId),
    TeamID               int            not null foreign key references Football.Team (TeamId),
    StartDate            DateTimeOffset not null,
    unique (DivisionID, TeamID, StartDate),
    EndDate              DateTimeOffset,

);

Create Table Football.PlayerTeamHistory
(
    PlayerTeamHistoryId int            not null identity (1, 1) primary key,
    PlayerID            int            not null foreign key references Football.Player (PlayerId),
    TeamID              int            not null foreign key references Football.Team (TeamId),
    StartDate           DateTimeOffset not null,
    unique (PlayerID, TeamID, StartDate),
    EndDate             DateTimeOffset,
    PositionId          int foreign key references Football.Positions (PositionId),
    PlayerNumber        int            not null,
);

Create Table Football.Stadium
(
    StadiumId int          not null identity (1, 1) primary key,
    Name      NVarChar(64) not null,
    State     NVarChar(32) not null,
    City      NVarChar(64) not null,
    TeamID    int foreign key references Football.Team (TeamId),
);
GO


--Stage 3
Create Table Football.Match
(
    MatchId    int            not null identity (1, 1) primary key,
    --TODO consider nullability of date
    Date       DateTimeOffset not null,
    StadiumId  int            not null foreign key references Football.Stadium (StadiumId),
    HomeTeamId int            not null foreign key references Football.Team (TeamId),
    AwayTeamId int            not null foreign key references Football.Team (TeamId),
);
GO


--Stage 4
Create Table Football.PlayerMatchStats
(
    PlayerMatchStatsId  int not null identity (1, 1) primary key,
    PlayerTeamHistoryId int not null foreign key references Football.PlayerTeamHistory (PlayerTeamHistoryId),
    MatchId             int not null foreign key references Football.Match (MatchId),
    unique (PlayerTeamHistoryId, MatchId),
    TeamID              int foreign key references Football.Team (TeamId), --TODO consider if this is really necessary
    Yards               int,
    Points              int,
    --TODO more stats
);
GO

/*
























 */